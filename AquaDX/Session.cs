
using System.Collections.Generic;
using System.Text;
using System.IO;
using Utils;

namespace AMDaemon
{
    public class AquaDXSession  : Singleton<AquaDXSession>
    {
        public static byte[] EncodeAllnet(Dictionary<string, string> data, bool base64 = false)
        {
            // key=value&key2=value
            string encoded = "";
            foreach (var pair in data)            
                encoded += pair.Key + "=" + pair.Value + "&";
            byte[] bytes = Encoding.UTF8.GetBytes(encoded);
            // compress with ZLib
            


        }
        public string KeychipID => Config.KeychipID;
        public string SessionID { get; private set; }

        public void Login()
        {

        }
    }
}