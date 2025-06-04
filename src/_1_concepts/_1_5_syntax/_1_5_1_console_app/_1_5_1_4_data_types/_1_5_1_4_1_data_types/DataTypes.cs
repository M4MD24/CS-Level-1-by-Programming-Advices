using System;

namespace CS_Level_1_by_Programming_Advices._1_concepts._1_5_syntax._1_5_1_console_app._1_5_1_4_data_types._1_5_1_4_1_data_types;

internal class DataTypes {
    public static void main(
        string[] args
    ) {
        byte    maxByte          = Byte.MaxValue;
        sbyte   minSignedByte    = SByte.MaxValue;
        short   minShort         = Int16.MaxValue;
        ushort  maxUnsignedShort = UInt16.MaxValue;
        int     maxInt           = Int32.MaxValue;
        uint    maxUnsignedInt   = UInt32.MaxValue;
        long    maxLong          = Int64.MaxValue;
        ulong   maxUnsignedLong  = UInt64.MaxValue;
        float   floatValue       = float.MaxValue;
        double  doubleValue      = Double.MaxValue;
        decimal decimalValue     = Decimal.MaxValue;
        char    character        = char.MaxValue;
        bool    isTrue           = true;

        string message       = "Hello, Developers!";
        object genericObject = new object();

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