using System.Collections.Generic;
using System.IO;

namespace Server_Manager.Databases
{
    public class Core
    {
        public List<CoreInformation> cores = new List<CoreInformation>()
        {
            /* Spigot */
            new CoreInformation("Spigot", "1.0", Versions.Version_1_12_2, "0A8A23442FF5DA3CB9FC4AB50BC8D79F"),

            /* CatServer */
            new CoreInformation("CatServer", "119130", Versions.Version_1_12_2, "840B845D22D6BD14EED53B572A8998B0"),

            /* Kettle */
            new CoreInformation("Kettle", "1.0", Versions.Version_1_12_2, "ABADC009562D97F3588C97CBE87F16E8"),

            /* KCauldron */
            new CoreInformation("KCauldron", "1420.120", Versions.Version_1_7_10, "D5F676A6200ADC293F3D1FDBE6218F25"),
            new CoreInformation("KCauldron", "1448.133", Versions.Version_1_7_10, "23ADDC86C9D58E466A19BFDFFA351466"),
            new CoreInformation("KCauldron", "1481.148", Versions.Version_1_7_10, "CC6080255E72BDACD1DDEE6491FEDFB2"),
            new CoreInformation("KCauldron", "1492.152", Versions.Version_1_7_10, "009DCB31F9E002CAFD212A3DA9DD8F0C"),

            /* Forge */
            new CoreInformation("Forge", "10.13.4.1614", Versions.Version_1_7_10, "ADD0FBA161C4652A96EFB4264EC2D9EC"),
            new CoreInformation("Forge", "14.23.5.2855", Versions.Version_1_12_2, "02FCC447BB8938E5214292E4D36EC949"),
        };

        public CoreInformation GetCore(string path)
        {
            string[] allfiles = Directory.GetFiles(path);
            foreach (string filename in allfiles)
            {
                FileInfo file = new FileInfo(filename);
                foreach (var core in cores)
                {
                    if (file.MD5() == core.hash)
                    {
                        core.path = file.FullName;
                        return core;
                    }
                }
            }
            return null;
        }

        public class CoreInformation
        {
            public string path;
            public string name;
            public Versions mcversion;
            public string version;

            public string hash;

            public CoreInformation(string Name, string Version, Versions MCVersion, string Hash)
            {
                this.name = Name;
                this.mcversion = MCVersion;
                this.hash = Hash;
                this.version = Version;
            }
        }
    }
}
