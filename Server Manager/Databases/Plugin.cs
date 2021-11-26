using System.Collections.Generic;
using System.IO;

namespace Server_Manager.Databases
{
    public class Plugin
    {
        public List<PluginInformation> plugins = new List<PluginInformation>()
        {
            new PluginInformation("Decent Holograms", "2.0.8", new List<Versions>() { Versions.Version_1_8, Versions.Version_1_8_2, Versions.Version_1_8_3, Versions.Version_1_8_4, Versions.Version_1_8_5, Versions.Version_1_8_6, Versions.Version_1_8_7, Versions.Version_1_8_8, Versions.Version_1_8_9, Versions.Version_1_9, Versions.Version_1_9_2, Versions.Version_1_9_4, Versions.Version_1_10, Versions.Version_1_10_1, Versions.Version_1_10_2, Versions.Version_1_11, Versions.Version_1_12, Versions.Version_1_12_1, Versions.Version_1_12_2, Versions.Version_1_13, Versions.Version_1_13_1, Versions.Version_1_13_2, Versions.Version_1_14, Versions.Version_1_14_1, Versions.Version_1_14_2, Versions.Version_1_14_3, Versions.Version_1_14_4, Versions.Version_1_15, Versions.Version_1_15_1, Versions.Version_1_15_2, Versions.Version_1_16, Versions.Version_1_16_1, Versions.Version_1_16_2, Versions.Version_1_16_3, Versions.Version_1_16_4, Versions.Version_1_16_5, Versions.Version_1_17, Versions.Version_1_17_1}, "https://www.spigotmc.org/resources/decent-holograms-placeholderapi-support-no-dependencies.96927/", "https://github.com/Nekiplay/MinecraftFiles/raw/main/plugins/DecentHolograms.jar", "0E444EDF5BA6F55907D0CB4965223904"),
        };


        public List<PluginInformation> GetPluginsByMinecraftVersion(Versions version)
        {
            List<PluginInformation> temp = new List<PluginInformation>();
            foreach (var plugin in plugins)
            {
                foreach (Versions v in plugin.mcversion)
                {
                    if (v == version)
                    {
                        temp.Add(plugin);
                    }
                }
            }
            return temp;
        }
        public List<PluginInformation> GetPlugins(string path)
        {
            List<PluginInformation> plugins = new List<PluginInformation>();
            string[] allfiles = Directory.GetFiles(path);
            foreach (string filename in allfiles)
            {
                FileInfo file = new FileInfo(filename);
                foreach (var plugin in plugins)
                {
                    if (file.MD5() == plugin.hash)
                    {
                        plugins.Add(plugin);
                    }
                }
            }
            return plugins;
        }

        public class PluginInformation
        {
            public string name;
            public string version;
            public List<Versions> mcversion;

            public string link;
            public string directlink;

            public string hash;

            public PluginInformation(string Name, string Version, List<Versions> MCVersion, string link, string directlink, string Hash)
            {
                this.name = Name;
                this.version = Version;
                this.mcversion = MCVersion;
                this.link = link;
                this.directlink = link;
                this.hash = Hash;
            }
        }
    }
}
