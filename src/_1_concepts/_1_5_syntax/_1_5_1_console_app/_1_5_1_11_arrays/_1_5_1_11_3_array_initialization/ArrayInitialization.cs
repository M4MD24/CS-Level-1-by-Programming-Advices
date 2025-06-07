using System;

namespace CS_Level_1_by_Programming_Advices._1_concepts._1_5_syntax._1_5_1_console_app._1_5_1_11_arrays._1_5_1_11_3_array_initialization;

internal class ArrayInitialization {
    public static void main(
        string[] args
    ) {
        int[] numbers = [
            1,
            2,
            3
        ];

        for (
            int index = 0;
            index < numbers.Length;
            index++
        )
            Console.WriteLine(
                numbers[index]
            );
    }
}