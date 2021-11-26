using System.Collections.Generic;
using System.IO;

namespace Server_Manager.Databases
{
    public class Core
    {
        public List<CoreInformation> cores = new List<CoreInformation>()
        {
            /* Spigot */
            new CoreInformation("Spigot", "1.0", "1.12.2", "0A8A23442FF5DA3CB9FC4AB50BC8D79F"),

            /* PaperSpigot */

            /* KCauldron */
            new CoreInformation("KCauldron", "1420.120", "1.7.10", "D5F676A6200ADC293F3D1FDBE6218F25"),
            new CoreInformation("KCauldron", "1448.133", "1.12.2", "23ADDC86C9D58E466A19BFDFFA351466"),
            new CoreInformation("KCauldron", "1481.148", "1.12.2", "CC6080255E72BDACD1DDEE6491FEDFB2"),
            new CoreInformation("KCauldron", "1492.152", "1.12.2", "009DCB31F9E002CAFD212A3DA9DD8F0C"),

            /* Forge */
            new CoreInformation("Forge", "10.13.4.1614", "1.7.10", "ADD0FBA161C4652A96EFB4264EC2D9EC"),
            new CoreInformation("Forge", "14.23.5.2855", "1.12.2", "02FCC447BB8938E5214292E4D36EC949"),
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
            public string mcversion;
            public string version;

            public string hash;

            public CoreInformation(string Name, string Version, string MCVersion, string Hash)
            {
                this.name = Name;
                this.mcversion = MCVersion;
                this.hash = Hash;
                this.version = Version;
            }
        }
    }
}
