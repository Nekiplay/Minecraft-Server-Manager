using System.Collections.Generic;
using System.IO;

namespace Server_Manager.Databases
{
    public class Core
    {
        public List<CoreInformation> cores = new List<CoreInformation>()
        {
            /* Spigot */
            new CoreInformation("Spigot", "1.0", Versions.Version_1_17_1, "279367F19DF9F45734F64EDE10821BD4"),
            new CoreInformation("Spigot", "1.0", Versions.Version_1_17, "E7208A2680692D1B42A9BAF3AB93A7F0"),
            new CoreInformation("Spigot", "1.0", Versions.Version_1_16_5, "D0FB2D3CA529BEB081B80C04EEEDDE04"),
            new CoreInformation("Spigot", "1.0", Versions.Version_1_16_4, "B451FF7CCA476850F3873BCAE8395C30"),
            new CoreInformation("Spigot", "1.0", Versions.Version_1_16_3, "80846E51EE42DAC24276CB30E05F7B3C"),
            new CoreInformation("Spigot", "1.0", Versions.Version_1_16_2, "F7A606956C49B0F745D2E17D233DCC1E"),
            new CoreInformation("Spigot", "1.0", Versions.Version_1_16_1, "63591079D1366B808433A9A9C8540AC8"),
            new CoreInformation("Spigot", "1.0", Versions.Version_1_15_2, "E48451389FF03CA3CA62636C17EB3DF0"),
            new CoreInformation("Spigot", "1.0", Versions.Version_1_15_1, "EB599786409409ACFD1DDA3EC590F5A1"),
            new CoreInformation("Spigot", "1.0", Versions.Version_1_15, "583B48A371BC250F67D99D4509196E0F"),
            new CoreInformation("Spigot", "1.0", Versions.Version_1_14_4, "10ED5C2C5AF1BAB664B0AA12D66FC741"),
            new CoreInformation("Spigot", "1.0", Versions.Version_1_14_3, "9B73DAE7E8799F81F085B4B4B2B492CD"),
            new CoreInformation("Spigot", "1.0", Versions.Version_1_14_2, "E35E46A6FF72631E2D11AFF070CE72DB"),
            new CoreInformation("Spigot", "1.0", Versions.Version_1_14_1, "C86AE3AA0128B67982C4452CB0F1EFE8"),
            new CoreInformation("Spigot", "1.0", Versions.Version_1_14, "CA70FE8F8275DB1C26B50482A613481B"),
            new CoreInformation("Spigot", "1.0", Versions.Version_1_13_2, "DA6352BE2BBF862005481C7C23776970"),
            new CoreInformation("Spigot", "1.0", Versions.Version_1_13_1, "7D890AEDFBE471E299ED595E49050E4D"),
            new CoreInformation("Spigot", "1.0", Versions.Version_1_13, "F6514628A7C5CE2D7D4848902DBC8D0D"),
            new CoreInformation("Spigot", "1.0", Versions.Version_1_12_2, "0A8A23442FF5DA3CB9FC4AB50BC8D79F"),
            new CoreInformation("Spigot", "1.0", Versions.Version_1_12_1, "C9323A37B1FCF3E4100D894AB625836E"),
            new CoreInformation("Spigot", "1.0", Versions.Version_1_12, "D65128BF43A587522FAC2FEF31CC9A15"),
            new CoreInformation("Spigot", "1.0", Versions.Version_1_11_2, "1E5A48DD7FF5D9376E29D2FA55BFD468"),
            new CoreInformation("Spigot", "1.0", Versions.Version_1_11_1, "D48FC7B792AEAE45725AF6EC112EFA92"),
            new CoreInformation("Spigot", "1.0", Versions.Version_1_11, "B636AF42A194FA2EC61BB436ED8DB2DE"),
            new CoreInformation("Spigot", "1.0", Versions.Version_1_10_2, "3A45BCA0FF166858584E7C86CC335037"),
            new CoreInformation("Spigot", "1.0", Versions.Version_1_10, "C488D3D5485C4B95C7D4C62D23AB079C"),
            new CoreInformation("Spigot", "1.0", Versions.Version_1_9_4, "2759925668545696DB0A2D2FA72BB981"),
            new CoreInformation("Spigot", "1.0", Versions.Version_1_9_2, "A787FF792E619269D2BF74944B84B585"),
            new CoreInformation("Spigot", "1.0", Versions.Version_1_9, "AC80295C9F9C0DBF0BA6A0687E9F266F"),
            new CoreInformation("Spigot", "1.0", Versions.Version_1_8_8, "EAB41AA7D76AF95C2F8540DF2C03EE33"),
            new CoreInformation("Spigot", "1.0", Versions.Version_1_8_7, "DDB90A9326FA1E73927AC0523245D3A1"),
            new CoreInformation("Spigot", "1.0", Versions.Version_1_8_6, "6153C37ACD914622825E58DBCD0C3533"),
            new CoreInformation("Spigot", "1.0", Versions.Version_1_8_5, "F3A8B0E74F8AEC6883CEAC70E92EE8F4"),
            new CoreInformation("Spigot", "1.0", Versions.Version_1_8_4, "9C2CBCC7131F21B5D2CF508DED9291D6"),
            new CoreInformation("Spigot", "1.0", Versions.Version_1_8_3, "F27E2ABFC24A25CAAE898E8E2239420A"),
            new CoreInformation("Spigot", "1.0", Versions.Version_1_7_10, "870C9021BE261BD285C966C642B23C32"),
            new CoreInformation("Spigot", "1.0", Versions.Version_1_7_9, "727BA618DE158AEFAF403BB455771EDE"),
            new CoreInformation("Spigot", "1.0", Versions.Version_1_7_8, "7E2E6BB626013368B134212A5EC76AA1"),
            new CoreInformation("Spigot", "1.0", Versions.Version_1_7_5, "76AD1A9809A014D3ADC70AD39FB8E610"),
            new CoreInformation("Spigot", "1.0", Versions.Version_1_7_2, "6685F2F76BF77E4DB785FB32EDBD313C"),
            new CoreInformation("Spigot", "1.0", Versions.Version_1_6_4, "B3C3EA5AC57D74288210A6F4BF712A3C"),
            new CoreInformation("Spigot", "1.0", Versions.Version_1_6_2, "16949FAF15A17005A32A8048944E7DD3"),
            new CoreInformation("Spigot", "1.0", Versions.Version_1_5_2, "3F7612FE14733AFFF548CF6A2C8109FB"),
            new CoreInformation("Spigot", "1.0", Versions.Version_1_5_1, "74DBB8B77CAA1F2F8941A3229F51FBA9"),
            new CoreInformation("Spigot", "1.0", Versions.Version_1_4_7, "CA2660DD58595706662C3789697F2EEC"),
            new CoreInformation("Spigot", "1.0", Versions.Version_1_4_6, "28898BBF7F917F7A97D2DB7EDF1BB7CB"),

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
