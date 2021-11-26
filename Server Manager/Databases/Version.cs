public static class Version
{
    public static string ToVersion(this Versions version)
    {
        switch (version)
        {
            case (Versions.Version_null):
                return "Unknow";
            case (Versions.Version_1_7_10):
                return "1.7.10";
            case (Versions.Version_1_8_9):
                return "1.8.9";
            case (Versions.Version_1_12_2):
                return "1.12.2";
            case (Versions.Version_1_13):
                return "1.13";
            case (Versions.Version_1_13_1):
                return "1.13.1";
            case (Versions.Version_1_13_2):
                return "1.13.2";
            case (Versions.Version_1_14):
                return "1.14";
            case (Versions.Version_1_14_1):
                return "1.14.1";
            case (Versions.Version_1_14_2):
                return "1.14.2";
            case (Versions.Version_1_14_3):
                return "1.14.3";
            case (Versions.Version_1_14_4):
                return "1.14.4";
            case (Versions.Version_1_15):
                return "1.15";
            case (Versions.Version_1_15_1):
                return "1.15.1";
            case (Versions.Version_1_15_2):
                return "1.15.2";
            case (Versions.Version_1_16):
                return "1.16";
            case (Versions.Version_1_16_1):
                return "1.16.1";
            case (Versions.Version_1_16_2):
                return "1.16.2";
            case (Versions.Version_1_16_3):
                return "1.16.3";
            case (Versions.Version_1_16_4):
                return "1.16.4";
            case (Versions.Version_1_16_5):
                return "1.16.5";
            case (Versions.Version_1_17):
                return "1.17";
            case (Versions.Version_1_17_1):
                return "1.17.1";
            default:
                return "Unknow";
        }
    }

}
public enum Versions
{
    Version_null,
    Version_1_7_10,
    Version_1_8_9,
    Version_1_12_2,
    Version_1_13,
    Version_1_13_1,
    Version_1_13_2,
    Version_1_14,
    Version_1_14_1,
    Version_1_14_2,
    Version_1_14_3,
    Version_1_14_4,
    Version_1_15,
    Version_1_15_1,
    Version_1_15_2,
    Version_1_16,
    Version_1_16_1,
    Version_1_16_2,
    Version_1_16_3,
    Version_1_16_4,
    Version_1_16_5,
    Version_1_17,
    Version_1_17_1,
}