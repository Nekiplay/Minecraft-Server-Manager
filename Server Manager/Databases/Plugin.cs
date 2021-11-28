using System.Collections.Generic;
using System.IO;

namespace Server_Manager.Databases
{
    public class Plugin
    {
        public List<PluginInformation> plugins = new List<PluginInformation>()
        {
            new PluginInformation("Decent Holograms", "2.0.8", Version.Version_1_8_9to1_17_1, new List<PluginInformation.Type>() { PluginInformation.Type.Design }, "https://www.spigotmc.org/resources/decent-holograms-placeholderapi-support-no-dependencies.96927", "https://github.com/Nekiplay/MinecraftFiles/raw/main/plugins/DecentHolograms.jar", "0E444EDF5BA6F55907D0CB4965223904"),
            new PluginInformation("InvisibleItemFrames", "2.2.2", Version.Version_1_16to1_17_1, new List<PluginInformation.Type>() { PluginInformation.Type.Design }, "https://www.spigotmc.org/resources/invisibleitemframes-better-item-frames.85085", "https://github.com/Nekiplay/MinecraftFiles/raw/main/plugins/InvisibleItemFrames-2.2.2.jar", "BB95A7FA81A2237EC3FCCB48FBD98D2F"),
            new PluginInformation("Badlion Client Api", "1.2.3", Version.Version_1_17to1_17_1, new List<PluginInformation.Type>() { PluginInformation.Type.Design }, "https://www.spigotmc.org/resources/badlion-client-api.97949/", "https://github.com/Nekiplay/MinecraftFiles/raw/main/plugins/badlionclientmodapispigot-1.17.jar", "11B92B075A497DB9AC9020DBC9FA2C80"),
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
            public enum Type
            {
                SkyBlock,
                Economy,
                PvP,
                Survival,
                Design,
                Unknow,
            }
            public string name;
            public string version;
            public List<Versions> mcversion;
            public List<Type> type;

            public string link;
            public string directlink;

            public string hash;

            public PluginInformation(string Name, string Version, List<Versions> MCVersion, List<Type> type, string link, string directlink, string Hash)
            {
                this.name = Name;
                this.version = Version;
                this.mcversion = MCVersion;
                this.link = link;
                this.directlink = directlink;
                this.hash = Hash;
            }
        }
    }
}
