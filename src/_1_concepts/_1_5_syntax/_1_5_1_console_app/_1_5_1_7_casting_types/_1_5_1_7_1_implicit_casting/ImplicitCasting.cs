using System;

namespace CS_Level_1_by_Programming_Advices._1_concepts._1_5_syntax._1_5_1_console_app._1_5_1_7_casting_types._1_5_1_7_1_implicit_casting;

internal class ImplicitCasting {
    public static void main(
        string[] args
    ) {
        int    integerValue    = 10;
        double doubleValue = integerValue; // Implicit casting: int to double

        Console.Write(
            $"Integer value: {integerValue}" +
            $"\nImplicitly casted to double: {doubleValue}"
        );
    }
}