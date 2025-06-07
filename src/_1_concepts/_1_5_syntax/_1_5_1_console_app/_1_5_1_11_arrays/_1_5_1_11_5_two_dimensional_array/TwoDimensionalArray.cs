using System;

namespace CS_Level_1_by_Programming_Advices._1_concepts._1_5_syntax._1_5_1_console_app._1_5_1_11_arrays._1_5_1_11_5_two_dimensional_array;

internal class TwoDimensionalArray {
    public static void main(
        string[] args
    ) {
        int[,] matrix = {
            {
                1,
                2,
                3
            }, {
                4,
                5,
                6
            }, {
                7,
                8,
                9
            }
        };

        Console.Write(
            matrix[
                1,
                2
            ]
        );
    }
}