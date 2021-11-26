using System.Collections.Generic;
using System.IO;

namespace Server_Manager.Databases
{
    public class Mod
    {
        public List<ModInformation> mods = new List<ModInformation>()
        {
            /* 1.7.10 */
            new ModInformation("Uncrafting Table", "1.4.7", new List<Versions>() { Versions.Version_1_7_10}, "https://www.curseforge.com/minecraft/mc-mods/jglrxavpoks-uncrafting-table", "https://github.com/Nekiplay/MinecraftFiles/raw/main/mods/1.7.10/1.7.10UncraftingTable_1.4.7.jar", "0C96CE669F910145F618A7A07845627C"),
            new ModInformation("Thermal Foundation", "1.2.6-118", new List<Versions>() { Versions.Version_1_7_10}, "https://www.curseforge.com/minecraft/mc-mods/thermal-foundation", "https://github.com/Nekiplay/MinecraftFiles/raw/main/mods/1.7.10/ThermalFoundation-%5B1.7.10%5D1.2.6-118.jar", "CC29BA7F9164BB5C78CEE67A3A23A81D"),
            new ModInformation("UniDict", "2.9", new List<Versions>() { Versions.Version_1_7_10}, "https://www.curseforge.com/minecraft/mc-mods/unidict", "https://github.com/Nekiplay/MinecraftFiles/raw/main/mods/1.7.10/UniDict_1.7.10_2.9.jar", "B8C4A15126554BA752FDD4102C98914A"),
            new ModInformation("Power Utilites", "1.0.4", new List<Versions>() { Versions.Version_1_7_10}, "https://minecraft-inside.ru/mods/68110-power-utils.html", "https://github.com/Nekiplay/MinecraftFiles/raw/main/mods/1.7.10/PowerUtils_1.7.10_1.0.4.jar", "122B66D10CC957C21B5109B630D07F79"),
            new ModInformation("AutoCrafter 2000", "1.0", new List<Versions>() { Versions.Version_1_7_10}, "https://www.curseforge.com/minecraft/mc-mods/autocrafter2000", "https://github.com/Nekiplay/MinecraftFiles/raw/main/mods/1.7.10/OpenBlocks-1.7.10-1.6.jar", "E0F2547A910516FD9B1A9445475A01AC"),
            new ModInformation("OpenBlocks", "1.6", new List<Versions>() { Versions.Version_1_7_10}, "https://www.curseforge.com/minecraft/mc-mods/openblocks", "https://github.com/Nekiplay/MinecraftFiles/raw/main/mods/1.7.10/OpenBlocks-1.7.10-1.6.jar", "26AA01A40B9EEB35A4D291EC9D6DD598"),
        };


        public List<ModInformation> GetModsByMinecraftVersion(Versions version)
        {
            List<ModInformation> temp = new List<ModInformation>();
            foreach (var mod in mods)
            {
                foreach (Versions v in mod.mcversion)
                {
                    if (v == version)
                    {
                        temp.Add(mod);
                    }
                }
            }
            return temp;
        }

        public List<ModInformation> GetMods(string path)
        {
            List<ModInformation> temp = new List<ModInformation>();
            string[] allfiles = Directory.GetFiles(path);
            foreach (string filename in allfiles)
            {
                FileInfo file = new FileInfo(filename);
                foreach (var plugin in mods)
                {
                    if (file.MD5() == plugin.hash)
                    {
                        temp.Add(plugin);
                    }
                }
            }
            return temp;
        }

        public class ModInformation
        {
            public string name;
            public string version;
            public List<Versions> mcversion;

            public string link;
            public string directlink;

            public string hash;

            public ModInformation(string Name, string Version, List<Versions> MCVersion, string link, string directlink, string Hash)
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
