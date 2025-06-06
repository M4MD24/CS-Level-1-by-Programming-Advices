using System;

namespace CS_Level_1_by_Programming_Advices._1_concepts._1_5_syntax._1_5_1_console_app._1_5_1_7_casting_types._1_5_1_7_2_explicit_casting;

internal class ExplicitCasting {
    public static void main(
        string[] args
    ) {
        double doubleValue  = 9.78;
        int    integerValue = (int) doubleValue; // Explicit casting: double to int (fractional part lost)

        Console.Write(
            $"Double value: {doubleValue}" +
            $"\nExplicitly casted to integer: {integerValue}"
        );
    }
}