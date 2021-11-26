using System.Collections.Generic;
using System.IO;

namespace Server_Manager.Databases
{
    public class Plugin
    {
        public List<PluginInformation> plugins = new List<PluginInformation>()
        {
            new PluginInformation("Decent Holograms", "2.0.8", "1.8 - 1.17", "https://www.spigotmc.org/resources/decent-holograms-placeholderapi-support-no-dependencies.96927/", "https://github.com/Nekiplay/MinecraftFiles/raw/main/plugins/DecentHolograms.jar", "0E444EDF5BA6F55907D0CB4965223904"),
        };

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
            public string mcversion;

            public string link;
            public string directlink;

            public string hash;

            public PluginInformation(string Name, string Version, string MCVersion, string link, string directlink, string Hash)
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
