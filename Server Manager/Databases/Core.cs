using System.Collections.Generic;
using System.IO;

namespace Server_Manager.Databases
{
    public class Core
    {
        public List<CoreInformation> cores = new List<CoreInformation>()
        {
            /* Spigot */
            new CoreInformation("Spigot", "1.0", "1.7.10", "0A8A23442FF5DA3CB9FC4AB50BC8D79F"),

            /* PaperSpigot */

            /* Forge */
            new CoreInformation("Forge", "1.0", "1.7.10", "ADD0FBA161C4652A96EFB4264EC2D9EC"),
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
