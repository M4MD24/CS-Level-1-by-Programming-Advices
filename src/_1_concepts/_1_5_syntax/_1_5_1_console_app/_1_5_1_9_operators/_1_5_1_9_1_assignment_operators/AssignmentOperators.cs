using System;

namespace CS_Level_1_by_Programming_Advices._1_concepts._1_5_syntax._1_5_1_console_app._1_5_1_9_operators._1_5_1_9_1_assignment_operators;

internal class AssignmentOperators {
    public static void Main(
        string[] args
    ) {
        int number = 10;

        Console.WriteLine(
            $"{number} += 5 -> {number += 5}"
        );

        Console.WriteLine(
            $"{number} -= 3 -> {number -= 3}"
        );

        Console.WriteLine(
            $"{number} *= 2 -> {number *= 2}"
        );

        Console.WriteLine(
            $"{number} /= 4 -> {number /= 4}"
        );

        Console.WriteLine(
            $"{number} %= 5 -> {number %= 5}"
        );

        Console.WriteLine(
            $"{number} &= 3 -> {number &= 3}" // Bitwise AND
        );

        Console.WriteLine(
            $"{number} |= 2 -> {number |= 2}" // Bitwise OR
        );

        Console.WriteLine(
            $"{number} ^= 1 -> {number ^= 1}" // Bitwise XOR
        );

        Console.WriteLine(
            $"{number} <<= 2 -> {number <<= 2}" // Left shift by 2 bits
        );

        Console.WriteLine(
            $"{number} >>= 1 -> {number >>= 1}" // Right shift by 1 bit
        );
    }
}