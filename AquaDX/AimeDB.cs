using System;
using System.Collections;
using System.IO;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using AMDaemon.AquaDX;
using MaimaiRE;
using UnityEngine;
using Config = AMDaemon.AquaDX.Config;
using Logger = MaimaiRE.Logger;

namespace AMDaemon
{
    namespace AquaDX
    {

        public static class AimeDbClient
        {
            private static readonly byte[] Key = Encoding.ASCII.GetBytes("Copyright(C)SEGA");

            public const ushort CmdFelicaLookup = 0x01;
            public const ushort CmdLookup = 0x04;
            public const ushort CmdRegister = 0x05;
            public const ushort CmdLog = 0x09;
            public const ushort CmdCampaign = 0x0b;
            public const ushort CmdTouch = 0x0d;
            public const ushort CmdLookupV2 = 0x0f;
            public const ushort CmdFelicaLookupV2 = 0x11;
            public const ushort CmdUnknown19 = 0x13;
            public const ushort CmdHello = 0x64;
            public const ushort CmdGoodbye = 0x66;

            private static byte[] Align16(byte[] src)
            {
                int padLen = 16 - (src.Length % 16);
                if (padLen == 16) return src;
                byte[] padded = new byte[src.Length + padLen];
                Buffer.BlockCopy(src, 0, padded, 0, src.Length);
                return padded;
            }

            private static byte[] Encrypt(byte[] src)
            {
                using (Aes aesAlg = Aes.Create())
                {
                    aesAlg.Key = Key;
                    aesAlg.Mode = CipherMode.ECB;
                    aesAlg.Padding = PaddingMode.None;
                    ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
                    using (MemoryStream msEncrypt = new MemoryStream())
                    {
                        using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                        {
                            csEncrypt.Write(src, 0, src.Length);
                            csEncrypt.FlushFinalBlock();
                            return msEncrypt.ToArray();
                        }
                    }
                }
            }

            private static byte[] Decrypt(byte[] src)
            {
                using (Aes aesAlg = Aes.Create())
                {
                    aesAlg.Key = Key;
                    aesAlg.Mode = CipherMode.ECB;
                    aesAlg.Padding = PaddingMode.None;
                    ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
                    using (MemoryStream msDecrypt = new MemoryStream(src))
                    {
                        using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                        {
                            using (MemoryStream resultStream = new MemoryStream())
                            {
                                csDecrypt.CopyTo(resultStream);
                                return resultStream.ToArray();
                            }
                        }
                    }
                }
            }

            private static byte[] Serialize(ushort type, byte[] keychip, byte[] payloadData)
            {
                Logger.Assert(keychip.Length == 12);

                byte[] alignedData = Align16(payloadData ?? new byte[0]);
                ushort length = (ushort)(alignedData.Length + 0x20);

                using (MemoryStream ms = new MemoryStream())
                using (BinaryWriter writer = new BinaryWriter(ms))
                {
                    writer.Write((ushort)0xa13e);
                    writer.Write((ushort)0x0000);
                    writer.Write(type);
                    writer.Write(length);
                    writer.Write((ushort)0x0000); // Result (set to 0 for requests)
                    writer.Write(new byte[6]); // Game ID (can be set if needed)
                    writer.Write(new byte[4]); // Store ID (can be set if needed)
                    writer.Write(keychip);
                    writer.Write(alignedData);
                    return ms.ToArray();
                }
            }

            private static (ushort type, byte[] data) Deserialize(byte[] decryptedPacket)
            {
                Logger.Assert(decryptedPacket.Length > 0x20);
                using (MemoryStream ms = new MemoryStream(decryptedPacket))
                using (BinaryReader reader = new BinaryReader(ms))
                {
                    ushort magic = reader.ReadUInt16();
                    Logger.Assert(magic == 0xa13e, "Invalid magic bytes in decrypted packet.");

                    reader.ReadUInt16(); // version
                    ushort responseType = reader.ReadUInt16();
                    ushort length = reader.ReadUInt16();

                    reader.ReadUInt16(); // result
                    reader.ReadBytes(10); // game id
                    reader.ReadBytes(12); // keychip

                    int payloadSize = length - 0x20;
                    Logger.Assert(payloadSize >= 0);
                    byte[] payloadData = reader.ReadBytes(payloadSize);

                    return (responseType, payloadData);
                }
            }

            // Generalized command sender
            private static async Task<(ushort responseType, byte[] responsePayload, Exception error)>
                SendAimeDbCommandAsync(
                    ushort commandType, byte[] keychip, byte[] requestPayload)
            {
                using (var client = new TcpClient())
                {
                    try
                    {
                        await client.ConnectAsync(Config.Instance.AquaDX_Host, Config.Instance.AquaDX_AimeDBPort);

                        using (var stream = client.GetStream())
                        {
                            byte[] requestPacket = Serialize(commandType, keychip, requestPayload);
                            byte[] encryptedRequest = Encrypt(requestPacket);

                            await stream.WriteAsync(encryptedRequest, 0, encryptedRequest.Length);

                            byte[] buffer = new byte[4096];
                            int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);

                            if (bytesRead == 0)
                            {
                                return (0, null, new IOException("Connection closed prematurely by server."));
                            }

                            byte[] receivedData = new byte[bytesRead];
                            Array.Copy(buffer, 0, receivedData, 0, bytesRead);

                            // Decrypt and Deserialize the response
                            byte[] decryptedResponse = Decrypt(receivedData);
                            var (respType, respPayload) = Deserialize(decryptedResponse);

                            return (respType, respPayload, null); // Success
                        }
                    }
                    catch (Exception ex)
                    {
                        return (0, null, ex);
                    }
                }
            }

            public static IEnumerator DoLookup(string keychipStr, string luidHex, Action<uint?> onComplete)
            {
                byte[] keychipBytes = new byte[12];
                byte[] luidBytes;
                Logger.Log($"LookUp AimeDB: keychipStr={keychipStr}, luidHex={luidHex}");
                try
                {
                    if (string.IsNullOrEmpty(keychipStr) || keychipStr.Length < 11)
                        throw new ArgumentException("Keychip string is null, empty, or too short (minimum 11 chars).",
                            nameof(keychipStr));
                    Encoding.ASCII.GetBytes(keychipStr, 0, 11, keychipBytes, 0);
                    keychipBytes[11] = 0x00;
                    luidBytes = Utils.HexStringToByteArray(luidHex);
                    if (luidBytes.Length != 10)
                        throw new ArgumentException("LUID hex string should be 10 bytes (20 characters).",
                            nameof(luidHex));
                }
                catch (Exception ex)
                {
                    Debug.LogError($"Error preparing parameters for AimeDB lookup: {ex.Message}");
                    onComplete?.Invoke(null);
                    yield break;
                }

                Debug.Log($"Starting AimeDB Lookup Coroutine for LUID: {luidHex}");


                Task<(ushort responseType, byte[] responsePayload, Exception error)> request
                    = SendAimeDbCommandAsync(CmdLookup, keychipBytes, luidBytes);

                // Wait for the task
                while (!request.IsCompleted)
                {
                    yield return null;
                }

                // Process the result from the generalized sender
                if (request.IsFaulted) // Should ideally not happen if exceptions are caught inside
                {
                    Debug.LogError($"AimeDB command task faulted: {request.Exception}");
                    onComplete?.Invoke(null);
                }
                else if (request.Result.error != null)
                {
                    Debug.LogError($"AimeDB command failed: {request.Result.error}");
                    onComplete?.Invoke(null);
                }
                else
                {
                    // Success, now interpret the specific response for Lookup
                    ushort responseType = request.Result.responseType;
                    byte[] responsePayload = request.Result.responsePayload;

                    if (responseType != CmdLookup)
                    {
                        Debug.LogError($"AimeDB lookup received unexpected response type: {responseType}");
                        onComplete?.Invoke(null);
                    }
                    else if (responsePayload == null || responsePayload.Length < 4)
                    {
                        Debug.LogError(
                            $"AimeDB lookup received invalid payload length: {(responsePayload == null ? "null" : responsePayload.Length.ToString())}");
                        onComplete?.Invoke(null);
                    }
                    else
                    {
                        // Parse the AimeID from the payload
                        uint aimeIdResult = BitConverter.ToUInt32(responsePayload, 0);

                        if (aimeIdResult == 0xFFFFFFFF)
                        {
                            Debug.LogWarning(
                                "AimeDB lookup returned Guest ID (0xFFFFFFFF). Card might not be registered.");
                            onComplete?.Invoke(null); // Treat Guest ID as failure for this callback
                        }
                        else
                        {
                            Debug.Log($"AimeDB lookup successful. AimeID: {aimeIdResult}");
                            onComplete?.Invoke(aimeIdResult);
                        }
                    }
                }
            }
        }

        public class AimeDbState : Singleton<AimeDbState>
        {
            public uint? AimeID = null;

            public IEnumerator Init(Action onComplete)
            {
                yield return AimeDbClient.DoLookup(Config.Instance.KeychipID, Config.Instance.AimeID20, new Action<uint?>(u => AimeID = u));
                onComplete?.Invoke();
            }
        }
    }
}