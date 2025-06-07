using System;

namespace CS_Level_1_by_Programming_Advices._1_concepts._1_5_syntax._1_5_1_console_app._1_5_1_9_operators._1_5_1_9_3_relational_operators;

internal class RelationalOperators {
    public static void main(
        string[] args
    ) {
        int firstNumber  = 10;
        int secondNumber = 20;

        // Equal to
        bool equal = firstNumber == secondNumber;
        Console.WriteLine(
            $"{firstNumber} == {secondNumber} : {equal}"
        );

        // Not equal to
        bool notEqual = firstNumber != secondNumber;
        Console.WriteLine(
            $"{firstNumber} != {secondNumber} : {notEqual}"
        );

        // Greater than
        bool greaterThan = firstNumber > secondNumber;
        Console.WriteLine(
            $"{firstNumber} > {secondNumber} : {greaterThan}"
        );

        // Less than
        bool lessThan = firstNumber < secondNumber;
        Console.WriteLine(
            $"{firstNumber} < {secondNumber} : {lessThan}"
        );

        // Greater than or equal to
        bool greaterThanOrEqual = firstNumber >= secondNumber;
        Console.WriteLine(
            $"{firstNumber} >= {secondNumber} : {greaterThanOrEqual}"
        );

        // Less than or equal to
        bool lessThanOrEqual = firstNumber <= secondNumber;
        Console.WriteLine(
            $"{firstNumber} <= {secondNumber} : {lessThanOrEqual}"
        );
    }
}