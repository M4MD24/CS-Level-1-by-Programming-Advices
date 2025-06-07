using System;

namespace CS_Level_1_by_Programming_Advices._1_concepts._1_5_syntax._1_5_1_console_app._1_5_1_14_methods._1_5_1_14_4_return_value;

internal class ReturnValue {
    public static void main(
        string[] args
    ) {
        int firstNumber  = 5,
            secondNumber = 3;
        int result = add(
            firstNumber,
            secondNumber
        );
        Console.Write(
            $"{firstNumber} + {secondNumber} = " + result
        );
    }

    private static int add(
        int firstNumber,
        int secondNumber
    ) {
        return firstNumber + secondNumber;
    }
}