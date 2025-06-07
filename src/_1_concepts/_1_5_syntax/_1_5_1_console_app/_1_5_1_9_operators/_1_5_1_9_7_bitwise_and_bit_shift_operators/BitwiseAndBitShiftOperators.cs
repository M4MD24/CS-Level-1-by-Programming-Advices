using System;

namespace CS_Level_1_by_Programming_Advices._1_concepts._1_5_syntax._1_5_1_console_app._1_5_1_9_operators._1_5_1_9_7_bitwise_and_bit_shift_operators;

internal class BitwiseAndBitShiftOperators {
    public static void Main(
        string[] args
    ) {
        int firstNumber  = 5; // 0101 in binary
        int secondNumber = 3; // 0011 in binary

        Console.WriteLine(
            "Bitwise Operators:"
        );
        Console.WriteLine(
            $"firstNumber & secondNumber = {firstNumber & secondNumber}"
        ); // 0001 -> 1
        Console.WriteLine(
            $"firstNumber | secondNumber = {firstNumber | secondNumber}"
        ); // 0111 -> 7
        Console.WriteLine(
            $"firstNumber ^ secondNumber = {firstNumber ^ secondNumber}"
        ); // 0110 -> 6
        Console.WriteLine(
            $"~firstNumber = {~firstNumber}"
        ); // Inverts bits -> -6

        Console.WriteLine(
            "\nBit Shift Operators:"
        );
        Console.WriteLine(
            $"firstNumber << 1 = {firstNumber << 1}"
        ); // 1010 -> 10
        Console.WriteLine(
            $"firstNumber >> 1 = {firstNumber >> 1}"
        ); // 0010 -> 2
    }
}