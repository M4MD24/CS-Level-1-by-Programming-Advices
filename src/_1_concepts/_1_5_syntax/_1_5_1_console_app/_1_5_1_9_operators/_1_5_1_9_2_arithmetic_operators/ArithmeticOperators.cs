using System;

namespace CS_Level_1_by_Programming_Advices._1_concepts._1_5_syntax._1_5_1_console_app._1_5_1_9_operators._1_5_1_9_2_arithmetic_operators;

internal class ArithmeticOperators {
    public static void main(
        string[] args
    ) {
        int firstNumber  = 10;
        int secondNumber = 3;

        // Addition
        int addition = firstNumber + secondNumber;
        Console.WriteLine(
            $"Addition: {firstNumber} + {secondNumber} = {addition}"
        );

        // Subtraction
        int subtraction = firstNumber - secondNumber;
        Console.WriteLine(
            $"Subtraction: {firstNumber} - {secondNumber} = {subtraction}"
        );

        // Multiplication
        int multiplication = firstNumber * secondNumber;
        Console.WriteLine(
            $"Multiplication: {firstNumber} * {secondNumber} = {multiplication}"
        );

        // Division (integer)
        int division = firstNumber / secondNumber;
        Console.WriteLine(
            $"Division (integer): {firstNumber} / {secondNumber} = {division}"
        );

        // Division (double)
        double anotherDivision = (double) firstNumber / secondNumber;
        Console.WriteLine(
            $"Division (float): {firstNumber} / {secondNumber} = {anotherDivision}"
        );

        // Modulus (remainder)
        int modulus = firstNumber % secondNumber;
        Console.WriteLine(
            $"Modulus: {firstNumber} % {secondNumber} = {modulus}"
        );
    }
}