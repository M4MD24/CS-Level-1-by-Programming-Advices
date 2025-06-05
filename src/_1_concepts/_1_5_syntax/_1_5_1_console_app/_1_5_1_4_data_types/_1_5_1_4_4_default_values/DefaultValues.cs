using System;

namespace CS_Level_1_by_Programming_Advices._1_concepts._1_5_syntax._1_5_1_console_app._1_5_1_4_data_types._1_5_1_4_4_default_values;

internal class DefaultValues {
    public static void main(
        string[] args
    ) {
        byte    maxByte          = default(byte);
        sbyte   minSignedByte    = default(sbyte);
        short   minShort         = default(short);
        ushort  maxUnsignedShort = default(ushort);
        int     maxInt           = default(int);
        uint    maxUnsignedInt   = default(uint);
        long    maxLong          = default(long);
        ulong   maxUnsignedLong  = default(ulong);
        float   floatValue       = default(float);
        double  doubleValue      = default(double);
        decimal decimalValue     = default(decimal);
        char    character        = default(char);
        bool    isTrue           = default(bool);

        string message       = default(string);
        object genericObject = default(object);

        Console.WriteLine(
            "byte: " + maxByte
        );
        Console.WriteLine(
            "signed byte: " + minSignedByte
        );
        Console.WriteLine(
            "short: " + minShort
        );
        Console.WriteLine(
            "unsinged short: " + maxUnsignedShort
        );
        Console.WriteLine(
            "int: " + maxInt
        );
        Console.WriteLine(
            "unsinged int: " + maxUnsignedInt
        );
        Console.WriteLine(
            "long: " + maxLong
        );
        Console.WriteLine(
            "unsinged long: " + maxUnsignedLong
        );
        Console.WriteLine(
            "float: " + floatValue
        );
        Console.WriteLine(
            "double: " + doubleValue
        );
        Console.WriteLine(
            "decimal: " + decimalValue
        );
        Console.WriteLine(
            "char: " + character
        );
        Console.WriteLine(
            "bool: " + isTrue
        );
        Console.WriteLine(
            "string: " + message
        );
        Console.WriteLine(
            "object: " + genericObject
        );
    }
}