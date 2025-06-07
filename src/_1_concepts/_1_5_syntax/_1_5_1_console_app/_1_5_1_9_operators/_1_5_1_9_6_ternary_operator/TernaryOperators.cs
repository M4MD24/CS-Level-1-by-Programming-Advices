using System;

namespace CS_Level_1_by_Programming_Advices._1_concepts._1_5_syntax._1_5_1_console_app._1_5_1_9_operators._1_5_1_9_6_ternary_operator;

internal class TernaryOperators {
    public static void Main(
        string[] args
    ) {
        int number = 10;

        // Ternary operator usage
        string result = number % 2 == 0
                                ? "Even"
                                : "Odd";

        Console.WriteLine(
            $"The number {number} is {result}."
        );
    }
}