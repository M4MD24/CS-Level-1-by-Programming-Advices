using System;

namespace CS_Level_1_by_Programming_Advices._1_concepts._1_5_syntax._1_5_1_console_app._1_5_1_3_variables._1_5_1_3_1_variables;

internal class Variables {
    public static void main(
        string[] args
    ) {
        string name = "Mohamed Sadawy";
        Console.WriteLine(
            name
        );

        int firstNumber = 10;
        Console.WriteLine(
            "First Number: " + firstNumber
        );

        float secondNumber = 20;
        Console.WriteLine(
            "Second Number: " + secondNumber
        );

        Console.WriteLine(
            "FirstNumber + SecondNumber = " + firstNumber + secondNumber // Concatenating
        );

        Console.WriteLine(
            "FirstNumber + SecondNumber = " + (firstNumber + secondNumber) // Valid Result
        );

        double thirdNumber = 25.89;
        Console.WriteLine(
            "Third Number: " + thirdNumber
        );

        char character = 'M';
        Console.WriteLine(
            "Character: " + character
        );

        bool boolean = true;
        Console.WriteLine(
            "Boolean: " + boolean
        );
    }
}