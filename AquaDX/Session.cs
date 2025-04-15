
using System.Collections.Generic;
using System.Text;
using System.IO;
using MaimaiRE;
using Ionic.Zlib;
using System;
using System.Collections;
using UnityEngine.Networking;
using System.Threading;
using System.Web;
using System.Linq;
using System.Drawing.Printing;

namespace AMDaemon
{
    namespace AquaDX
    {
        public class Session : Singleton<Session>
        {
            public static byte[] EncodeAllnet(Dictionary<string, string> data, bool base64 = false)
            {
                string encoded = "";
                foreach (var pair in data)
                    encoded += pair.Key + "=" + pair.Value + "&";
                byte[] bytes = Encoding.UTF8.GetBytes(encoded.TrimEnd('&'));
                using (MemoryStream ms = new MemoryStream())
                {
                    // XXX: Could've just used DeflateStream instead?
                    using (ZlibStream zlibStream =
                           new ZlibStream(ms, CompressionMode.Compress, CompressionLevel.BestCompression))
                    {
                        zlibStream.Write(bytes, 0, bytes.Length);
                    }

                    bytes = ms.ToArray();
                }

                if (base64)
                    return Encoding.UTF8.GetBytes(Convert.ToBase64String(bytes));
                return bytes;
            }

            public string KeychipID => MaimaiRE.Config.Instance.EncodedKeychipID;
            public bool IsValid => !string.IsNullOrEmpty(KeychipID);

            private string _ServerEndpoint = "";
            public string ServerEndpoint => _ServerEndpoint;
            
            public IEnumerator SendPowerOnRequestCoroutine(Action<string?> onComplete)
            {
                const string endpoint = "/sys/servlet/PowerOn";
                string url = "http://" + Config.Instance.AquaDX_Host + endpoint;

                Logger.Log($"Sending PowerOn request to: {url}, keychip: {KeychipID}");

                Dictionary<string, string> data = new Dictionary<string, string>
                {
                    { "serial", KeychipID },
                    { "game_id", "SDGA" },
                    { "ver", "1.50" }
                };

                byte[] encoded = EncodeAllnet(data, true);
                using (UnityWebRequest request = new UnityWebRequest(url, "POST"))
                {
                    request.uploadHandler = new UploadHandlerRaw(encoded);
                    request.downloadHandler = new DownloadHandlerBuffer();
                    request.SetRequestHeader("Content-Type", "text/plain");
                    request.timeout = 15;

                    yield return request.SendWebRequest();
                    while (!request.isDone)  { yield return null; }
                    if (request.result != UnityWebRequest.Result.Success)
                    {
                        Logger.Error($"PowerOn request failed: {request.error},{request.result},{request.responseCode}");
                        onComplete?.Invoke(null);
                        yield break;
                    }
                    string query = request.downloadHandler.text;
                    var dict = query
                        .Split('&', StringSplitOptions.RemoveEmptyEntries)
                        .Select(param => param.Split('='))
                        .Where(kv => kv.Length == 2) // Add safety check for split result length
                        .ToDictionary(
                            kv => Uri.UnescapeDataString(kv[0]),
                            kv => Uri.UnescapeDataString(kv[1])
                        );

                    if (dict.TryGetValue("uri", out string serverUri))
                    {
                        _ServerEndpoint = serverUri.Replace("http://", "");
                        Logger.Log($"Server endpoint updated: {_ServerEndpoint}");
                        onComplete?.Invoke(_ServerEndpoint);   
                    }
                    else
                    {
                        Logger.Error("Missing uri key.");
                        onComplete?.Invoke(null);
                    }
                }
            }
        }
    }
}