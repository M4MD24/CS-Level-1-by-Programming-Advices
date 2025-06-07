using System;

namespace CS_Level_1_by_Programming_Advices._1_concepts._1_5_syntax._1_5_1_console_app._1_5_1_9_operators._1_5_1_9_5_unary_operators;

internal class UnaryOperators {
    public static void main(
        string[] args
    ) {
        int number = 5;
        Console.WriteLine(
            "Initial value: " + number
        );

        number++;
        Console.WriteLine(
            "After number++: " + number
        );

        ++number;
        Console.WriteLine(
            "After ++number: " + number
        );

        number--;
        Console.WriteLine(
            "After number--: " + number
        );

        --number;
        Console.WriteLine(
            "After --number: " + number
        );

        int secondNumber = -number;
        Console.WriteLine(
            "Unary minus (-number): " + secondNumber
        );

        bool flag = true;
        Console.WriteLine(
            "!flag: " + !flag
        );

        int thirdNumber = ~number;
        Console.WriteLine(
            "Bitwise complement (~number): " + thirdNumber
        );
    }
}