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
}