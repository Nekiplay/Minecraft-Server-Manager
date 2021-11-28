using System.Collections.Generic;

public static class Version
{
    public static List<Versions> Version_1_17to1_17_1
    {
        get
        {
            return new List<Versions>()
            {
                Versions.Version_1_17, Versions.Version_1_17_1
            };
        }
    }
    public static List<Versions> Version_1_16to1_17_1
    {
        get
        {
            return new List<Versions>()
            {
                Versions.Version_1_16, Versions.Version_1_16_1, Versions.Version_1_16_2, Versions.Version_1_16_3, Versions.Version_1_16_4, Versions.Version_1_16_5, Versions.Version_1_17, Versions.Version_1_17_1
            };
        }
    }
    public static List<Versions> Version_1_8_9to1_17_1
    {
        get
        {
            return new List<Versions>()
            {
                Versions.Version_1_8, Versions.Version_1_8_2, Versions.Version_1_8_3, Versions.Version_1_8_4, Versions.Version_1_8_5, Versions.Version_1_8_6, Versions.Version_1_8_7, Versions.Version_1_8_8, Versions.Version_1_8_9, Versions.Version_1_9, Versions.Version_1_9_2, Versions.Version_1_9_4, Versions.Version_1_10, Versions.Version_1_10_1, Versions.Version_1_10_2, Versions.Version_1_11, Versions.Version_1_12, Versions.Version_1_12_1, Versions.Version_1_12_2, Versions.Version_1_13, Versions.Version_1_13_1, Versions.Version_1_13_2, Versions.Version_1_14, Versions.Version_1_14_1, Versions.Version_1_14_2, Versions.Version_1_14_3, Versions.Version_1_14_4, Versions.Version_1_15, Versions.Version_1_15_1, Versions.Version_1_15_2, Versions.Version_1_16, Versions.Version_1_16_1, Versions.Version_1_16_2, Versions.Version_1_16_3, Versions.Version_1_16_4, Versions.Version_1_16_5, Versions.Version_1_17, Versions.Version_1_17_1
            };
        }
    }

    public static List<Versions> Version_1_7_10to1_17_1
    {
        get
        {
            return new List<Versions>()
            {
                Versions.Version_1_7_10, Versions.Version_1_8, Versions.Version_1_8_2, Versions.Version_1_8_3, Versions.Version_1_8_4, Versions.Version_1_8_5, Versions.Version_1_8_6, Versions.Version_1_8_7, Versions.Version_1_8_8, Versions.Version_1_8_9, Versions.Version_1_9, Versions.Version_1_9_2, Versions.Version_1_9_4, Versions.Version_1_10, Versions.Version_1_10_1, Versions.Version_1_10_2, Versions.Version_1_11, Versions.Version_1_12, Versions.Version_1_12_1, Versions.Version_1_12_2, Versions.Version_1_13, Versions.Version_1_13_1, Versions.Version_1_13_2, Versions.Version_1_14, Versions.Version_1_14_1, Versions.Version_1_14_2, Versions.Version_1_14_3, Versions.Version_1_14_4, Versions.Version_1_15, Versions.Version_1_15_1, Versions.Version_1_15_2, Versions.Version_1_16, Versions.Version_1_16_1, Versions.Version_1_16_2, Versions.Version_1_16_3, Versions.Version_1_16_4, Versions.Version_1_16_5, Versions.Version_1_17, Versions.Version_1_17_1
            };
        }
    }

    public static List<Versions> Version_1_7_2to1_17_1
    {
        get
        {
            return new List<Versions>()
            {
                Versions.Version_1_7_2, Versions.Version_1_7_5, Versions.Version_1_7_8, Versions.Version_1_7_9, Versions.Version_1_7_10, Versions.Version_1_8, Versions.Version_1_8_2, Versions.Version_1_8_3, Versions.Version_1_8_4, Versions.Version_1_8_5, Versions.Version_1_8_6, Versions.Version_1_8_7, Versions.Version_1_8_8, Versions.Version_1_8_9, Versions.Version_1_9, Versions.Version_1_9_2, Versions.Version_1_9_4, Versions.Version_1_10, Versions.Version_1_10_1, Versions.Version_1_10_2, Versions.Version_1_11, Versions.Version_1_12, Versions.Version_1_12_1, Versions.Version_1_12_2, Versions.Version_1_13, Versions.Version_1_13_1, Versions.Version_1_13_2, Versions.Version_1_14, Versions.Version_1_14_1, Versions.Version_1_14_2, Versions.Version_1_14_3, Versions.Version_1_14_4, Versions.Version_1_15, Versions.Version_1_15_1, Versions.Version_1_15_2, Versions.Version_1_16, Versions.Version_1_16_1, Versions.Version_1_16_2, Versions.Version_1_16_3, Versions.Version_1_16_4, Versions.Version_1_16_5, Versions.Version_1_17, Versions.Version_1_17_1
            };
        }
    }

    public static string ToVersion(this Versions version)
    {
        switch (version)
        {
            case (Versions.Version_null):
                return "Unknow";
            case (Versions.Version_1_4_6):
                return "1.4.6";
            case (Versions.Version_1_4_7):
                return "1.4.7";
            case (Versions.Version_1_5_1):
                return "1.5.1";
            case (Versions.Version_1_5_2):
                return "1.5.2";
            case (Versions.Version_1_6_2):
                return "1.6.2";
            case (Versions.Version_1_6_4):
                return "1.6.4";
            case (Versions.Version_1_7_2):
                return "1.7.2";
            case (Versions.Version_1_7_5):
                return "1.7.5";
            case (Versions.Version_1_7_8):
                return "1.7.8";
            case (Versions.Version_1_7_9):
                return "1.7.9";
            case (Versions.Version_1_7_10):
                return "1.7.10";
            case (Versions.Version_1_8):
                return "1.8";
            case (Versions.Version_1_8_2):
                return "1.8.2";
            case (Versions.Version_1_8_3):
                return "1.8.3";
            case (Versions.Version_1_8_4):
                return "1.8.4";
            case (Versions.Version_1_8_5):
                return "1.8.5";
            case (Versions.Version_1_8_6):
                return "1.8.6";
            case (Versions.Version_1_8_7):
                return "1.8.7";
            case (Versions.Version_1_8_8):
                return "1.8.8";
            case (Versions.Version_1_8_9):
                return "1.8.9";
            case (Versions.Version_1_9):
                return "1.9";
            case (Versions.Version_1_9_2):
                return "1.9.2";
            case (Versions.Version_1_9_4):
                return "1.9.4";
            case (Versions.Version_1_10):
                return "1.10";
            case (Versions.Version_1_10_1):
                return "1.10.1";
            case (Versions.Version_1_10_2):
                return "1.10.2";
            case (Versions.Version_1_11):
                return "1.11";
            case (Versions.Version_1_11_1):
                return "1.11.1";
            case (Versions.Version_1_11_2):
                return "1.11.2";
            case (Versions.Version_1_12):
                return "1.12";
            case (Versions.Version_1_12_1):
                return "1.12.1";
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
    Version_1_4_6,
    Version_1_4_7,
    Version_1_5_1,
    Version_1_5_2,
    Version_1_6_2,
    Version_1_6_4,
    Version_1_7_2,
    Version_1_7_5,
    Version_1_7_8,
    Version_1_7_9,
    Version_1_7_10,
    Version_1_8,
    Version_1_8_2,
    Version_1_8_3,
    Version_1_8_4,
    Version_1_8_5,
    Version_1_8_6,
    Version_1_8_7,
    Version_1_8_8,
    Version_1_8_9,
    Version_1_9,
    Version_1_9_2,
    Version_1_9_4,
    Version_1_10,
    Version_1_10_1,
    Version_1_10_2,
    Version_1_11,
    Version_1_11_1,
    Version_1_11_2,
    Version_1_12,
    Version_1_12_1,
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