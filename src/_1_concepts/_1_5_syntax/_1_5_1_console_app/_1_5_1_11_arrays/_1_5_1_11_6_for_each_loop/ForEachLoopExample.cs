using System;

namespace CS_Level_1_by_Programming_Advices._1_concepts._1_5_syntax._1_5_1_console_app._1_5_1_11_arrays._1_5_1_11_6_for_each_loop;

internal class ForEachLoopExample {
    public static void main(
        string[] args
    ) {
        int[] numbers = [
            1,
            2,
            3
        ];

        foreach (int number in numbers)
            Console.WriteLine(
                number
            );
    }
}