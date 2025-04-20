using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using CardMakerRE;
using Ionic.Zlib;
using UnityEngine;

namespace AMDaemon.AquaDX
{
    public class Session : Singleton<Session>
    {
        private static string BuildCompressedBase64(Dictionary<string, string> data)
        {
            string query = string.Join("&", data.Select(kv => $"{kv.Key}={kv.Value}"));
            byte[] raw   = Encoding.UTF8.GetBytes(query);

            using MemoryStream ms = new();
            using (ZlibStream zs = new(ms, CompressionMode.Compress, Ionic.Zlib.CompressionLevel.BestCompression))
            {
                zs.Write(raw, 0, raw.Length);
            }
            return Convert.ToBase64String(ms.ToArray());
        }
        public string KeychipID => CardMakerConfig.Instance.EncodedKeychipID;
        public bool   IsValid   => !string.IsNullOrEmpty(KeychipID);

        private string _serverEndpoint = string.Empty;
        public  string ServerEndpoint  => _serverEndpoint;
        public IEnumerator SendPowerOnRequestCoroutine(Action<string?> onComplete)
        {
            if (!IsValid)
            {
                Debug.LogError("[AquaDX] KeychipID missing – aborting PowerOn.");
                onComplete?.Invoke(null);
                yield break;
            }

            string host = Config.Instance.AquaDX_Host;
            string urlPath = "/sys/servlet/PowerOn";
            Debug.Log($"[AquaDX] PowerOn(raw) → http://{host}{urlPath}");

            Dictionary<string, string> fields = new()
            {
                { "serial",     KeychipID         },
                { "game_id",    "SDED"            },
                { "ver",        "1.35"            },
                { "ip",         "45.76.58.145"    },
                { "firm_ver",   "50000"           },
                { "boot_ver",   "0000"            },
                { "encode",     "UTF-8"           },
                { "format_ver", "3"               },
                { "hops",       "1"               },
                { "token",      "1956721072"      }
            };

            string body = BuildCompressedBase64(fields);
            Task<string?> t = SendRawPowerOnAsync(host, 80, urlPath, body);

            while (!t.IsCompleted) yield return null;

            if (t.Result != null)
            {
                _serverEndpoint = t.Result;
                Debug.Log($"[AquaDX] ✅ ServerEndpoint = {_serverEndpoint}");
            }
            else
            {
                Debug.LogError("[AquaDX] Failed to obtain server URI.");
            }

            onComplete?.Invoke(_serverEndpoint.Length > 0 ? _serverEndpoint : null);
        }
        private static async Task<string?> SendRawPowerOnAsync(string host, int port,
                                                               string path, string body)
        {
            byte[] bodyBytes = Encoding.ASCII.GetBytes(body);
            int    len       = bodyBytes.Length;
            string header =
                $"POST {path} HTTP/1.0\r\n" +
                "Connection: Close\r\n" +
                "Pragma: DFI\r\n" +
                "User-Agent: Windows/ver.3.0\r\n" +
                "Host: naominet.jp\r\n" +
                "Content-Type: application/x-www-form-urlencoded\r\n" +
                $"Content-Length: {len}\r\n" +
                "\r\n";

            byte[] headerBytes = Encoding.ASCII.GetBytes(header);

            using TcpClient client = new();
            try
            {
                await client.ConnectAsync(host, port);
            }
            catch (Exception ex)
            {
                Debug.LogError($"[AquaDX] TCP connect failed: {ex.Message}");
                return null;
            }
            using NetworkStream ns = client.GetStream();
            try
            {
                await ns.WriteAsync(headerBytes, 0, headerBytes.Length);
                await ns.WriteAsync(bodyBytes,   0, bodyBytes.Length);
                await ns.FlushAsync();
            }
            catch (Exception ex)
            {
                Debug.LogError($"[AquaDX] TCP write failed: {ex.Message}");
                return null;
            }
            using MemoryStream ms = new();
            byte[] buffer = new byte[4096];
            int read;
            try
            {
                while ((read = await ns.ReadAsync(buffer, 0, buffer.Length)) > 0)
                    ms.Write(buffer, 0, read);
            }
            catch (Exception ex)
            {
                Debug.LogError($"[AquaDX] TCP read failed: {ex.Message}");
                return null;
            }

            string response = Encoding.ASCII.GetString(ms.ToArray());
            int bodyIdx = response.IndexOf("\r\n\r\n", StringComparison.Ordinal);
            if (bodyIdx < 0)
            {
                Debug.LogError("[AquaDX] No HTTP separator found.");
                return null;
            }
            string respBody = response.Substring(bodyIdx + 4).Trim();
            Debug.Log($"[AquaDX] RAW reply body: \"{respBody}\"");

            var kv = respBody.Split('&', StringSplitOptions.RemoveEmptyEntries)
                             .Select(p => p.Split('='))
                             .Where(a => a.Length == 2)
                             .ToDictionary(a => Uri.UnescapeDataString(a[0]).Trim(),
                                           a => Uri.UnescapeDataString(a[1]).Trim());

            return kv.TryGetValue("uri", out var uri)
                    ? uri.Replace("http://", "")
                    : null;
        }
    }
}
