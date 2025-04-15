using MaimaiRE;

namespace AMDaemon
{
    namespace AquaDX
    {
        public class Config : Singleton<Config>
        {
            public string AquaDX_Host = "aquadx.hydev.org";
            public int AquaDX_AimeDBPort = 22345;

            public string KeychipID; // Encoded. AXXXXXXXXXX (11 (1+10) digits long)
            public string AimeID20; // 20 digits long (10 bytes hex string)
        }
    }
}
