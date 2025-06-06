using System;

namespace CS_Level_1_by_Programming_Advices._1_concepts._1_5_syntax._1_5_1_console_app._1_5_1_7_casting_types._1_5_1_7_4_enums_conversion;

internal class EnumsConversion {
    private enum Color {
        Red,
        LimeGreen,
        Gold,
        DeepSkyBlue,
        DeepPink,
        Black,
        Burgundy
    }

    public static void main(
        string[] args
    ) {
        Color color     = Color.DeepSkyBlue;
        int   dayNumber = (int) color; // Note: Explicit casting is required to convert from an enum type to its underlying integral type.
        Console.Write(
            $"{color} Number = {dayNumber}"
        );
    }
}