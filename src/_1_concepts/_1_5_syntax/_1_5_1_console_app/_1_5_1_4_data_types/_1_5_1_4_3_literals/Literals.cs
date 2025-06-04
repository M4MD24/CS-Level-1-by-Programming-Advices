using System;

namespace CS_Level_1_by_Programming_Advices._1_concepts._1_5_syntax._1_5_1_console_app._1_5_1_4_data_types._1_5_1_4_3_literals;

internal class Literals {
    public static void Main(
        string[] args
    ) {
        int hexadecimalValue = 0x2A;
        int binaryValue      = 0b00101010;

        Console.WriteLine(
            "Binary Value: {0}",
            binaryValue
        );

        Console.WriteLine(
            "Hexadecimal Value: {0}",
            hexadecimalValue
        );
    }
}