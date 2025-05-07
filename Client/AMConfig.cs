

using System.Collections.Generic;

namespace AMDaemon
{
    namespace Client
    {
        public class AMConfig : Internal.Singleton<AMConfig>
        {
            /// <summary>
            /// Your favorite custom server host e.g. "amime.missless.net", "aquadx.hydev.org"
            /// </summary>
            public string Host;
            /// <summary>
            /// Usually 22345. This should not be changed in most cases.
            /// </summary>
            public int AimeDbPort = 22345;
            /// <summary>
            /// AimeDB fields, e.g.
            ///    // { "serial",     KeychipID         }, (always automatically added)            
            ///    { "game_id",    "SDED"            },
            ///    { "ver",        "1.35"            },
            ///    { "ip",         "45.76.58.145"    },
            ///    { "firm_ver",   "50000"           },
            ///    { "boot_ver",   "0000"            },
            ///    { "encode",     "UTF-8"           },
            ///    { "format_ver", "3"               },
            ///    { "hops",       "1"               },
            ///    { "token",      "1956721072"      }
            /// </summary>
            public Dictionary<string, string> AimeFields;
            /// <summary>
            /// Encoded keychip ID, 11 (1+10) digits long e.g. AXXXXXXXXXX
            /// </summary>
            public string KeychipID;
            /// <summary>
            /// AKA LUID. 20 digits long (10 bytes hex string) e.g. "00010203040506070809"
            /// </summary>
            public string AimeID20;
            
            public string InvalidReason()
            {
                if (Host == null) return "Host not configured.";                
                if (AimeFields == null) return "AimeFields not configured.";
                if (KeychipID == null) return "Missing Keychip.";
                if (AimeID20 == null) return "Missing AimeID20 (LUID)";
                return null;
            }
            public bool IsValid => InvalidReason() == null;
            public string EncodedKeychipID => Utils.EncodeKeychipID(KeychipID);
        }
    }
}
