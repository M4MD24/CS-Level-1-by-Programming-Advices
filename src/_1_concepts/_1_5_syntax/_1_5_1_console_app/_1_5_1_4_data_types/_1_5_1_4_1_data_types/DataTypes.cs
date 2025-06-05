using System;

namespace CS_Level_1_by_Programming_Advices._1_concepts._1_5_syntax._1_5_1_console_app._1_5_1_4_data_types._1_5_1_4_1_data_types;

internal class DataTypes {
    public static void main(
        string[] args
    ) {
        byte    byteValue          = Byte.MaxValue;
        sbyte   signedByteValue    = SByte.MaxValue;
        short   shortValue         = Int16.MaxValue;
        ushort  unsignedShortValue = UInt16.MaxValue;
        int     intValue           = Int32.MaxValue;
        uint    unsignedIntValue   = UInt32.MaxValue;
        long    longValue          = Int64.MaxValue;
        ulong   unsignedLongValue  = UInt64.MaxValue;
        float   floatValue         = float.MaxValue;
        double  doubleValue        = Double.MaxValue;
        decimal decimalValue       = Decimal.MaxValue;
        char    characterValue     = char.MaxValue;
        bool    booleanValue       = true;

        string stringValue = "Hello, Developers!";
        object objectValue = new object();

        Console.WriteLine(
            "byte: " + byteValue
        );
        Console.WriteLine(
            "signed byte: " + signedByteValue
        );
        Console.WriteLine(
            "short: " + shortValue
        );
        Console.WriteLine(
            "unsinged short: " + unsignedShortValue
        );
        Console.WriteLine(
            "int: " + intValue
        );
        Console.WriteLine(
            "unsinged int: " + unsignedIntValue
        );
        Console.WriteLine(
            "long: " + longValue
        );
        Console.WriteLine(
            "unsinged long: " + unsignedLongValue
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
            "char: " + characterValue
        );
        Console.WriteLine(
            "bool: " + booleanValue
        );
        Console.WriteLine(
            "string: " + stringValue
        );
        Console.WriteLine(
            "object: " + objectValue
        );
    }
}