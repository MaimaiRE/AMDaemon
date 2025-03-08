
using System.Collections.Generic;
using System.Text;
using System.IO;
using MaimaiRE;
using Ionic.Zlib;
using System;
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
                    using (ZlibStream zlibStream = new ZlibStream(ms, CompressionMode.Compress, CompressionLevel.BestCompression))
                    {
                        zlibStream.Write(bytes, 0, bytes.Length);
                    }
                    bytes = ms.ToArray();
                }
                if (base64)
                    return Encoding.UTF8.GetBytes(Convert.ToBase64String(bytes));
                return bytes;
            }
            public string KeychipID { get
                {
                    string src = Config.Instance.KeychipID;
                    if (string.IsNullOrEmpty(src)) return null;
                    string ret = src.Substring(0, 4) + src.Substring(4, 7);
                    return ret;
                }
            }
            public bool IsValid => !string.IsNullOrEmpty(KeychipID);
            private string _ServerEndpoint;
            public string GetServerEndpoint()
            {
                if (_ServerEndpoint != null) return _ServerEndpoint;
                if (string.IsNullOrEmpty(KeychipID)) return null;
                SendPowerOnRequest();
                // Logger.Assert(_ServerEndpoint != null, "Login failed.");
                return _ServerEndpoint;
            }
            private bool shouldRetry = true;
            public void SendPowerOnRequest()
            {
                if (!shouldRetry) return;
                const string endpoint = "/sys/servlet/PowerOn";

                Dictionary<string, string> data = new Dictionary<string, string>
                {
                    { "serial", KeychipID },
                    { "game_id", "SDGA" },
                    { "ver", "1.50" }
                };
                byte[] encoded = EncodeAllnet(data, true);
                string url = Config.Instance.Server + endpoint;
                try
                {
                    using (UnityWebRequest request = new UnityWebRequest(url, "POST"))
                    {
                        request.uploadHandler = new UploadHandlerRaw(encoded);
                        request.downloadHandler = new DownloadHandlerBuffer();
                        request.SetRequestHeader("Content-Type", "text/plain");
                        request.SendWebRequest();
                        // TODO: Async
                        while (!request.isDone) { Thread.Sleep(100); }
                        if (request.responseCode != 200)
                        {
                            Logger.Error($"Rejected PowerOn request: {request.responseCode}, {request.downloadHandler.text}");
                            shouldRetry = false;
                            return;
                        }
                        string query = request.downloadHandler.text;
                        // stat=1&name=&place_id=123&region0=1&region_name0=W&region_name1=X&region_name2=Y&region_name3=Z&country=JPN&nickname=AquaDX&uri=http://aquadx.hydev.org/gs/4_HUJegC1Z6XBQYYtDKyfcKonW6u~GBP/mai2/&host=aquadx.hydev.org&allnet_id=456&client_timezone=+0900&utc_time=2025-03-06T14:26:11Z&setting=&res_ver=3&token=null
                        var dict = query
                            .Split('&', StringSplitOptions.RemoveEmptyEntries)
                            .Select(param => param.Split('='))
                            .ToDictionary(kv => Uri.UnescapeDataString(kv[0]), kv => Uri.UnescapeDataString(kv[1]));
                        _ServerEndpoint = dict["uri"];
                        _ServerEndpoint = _ServerEndpoint.Replace("http://", "");
                        Logger.Log($"Server endpoint: {_ServerEndpoint}");
                    }
                }
                catch (Exception e)
                {
                    Logger.Error($"Failed to send PowerOn request: {e}");
                    shouldRetry = false;
                }
            }
        }
    }
}