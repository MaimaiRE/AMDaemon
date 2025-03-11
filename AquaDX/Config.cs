using MaimaiRE;

namespace AMDaemon
{
    namespace AquaDX
    {
        public class Config : Singleton<Config>
        {
            public string Server { get; set; }
            public string KeychipID { get; set; }       

            public uint AimeID { get; set; }
        }
    }
}
