using System;

namespace CS_Level_1_by_Programming_Advices._1_concepts._1_5_syntax._1_5_1_console_app._1_5_1_10_control_flow._1_5_1_10_7_break_statement;

internal class BreakStatement {
    public static void Main(
        string[] args
    ) {
        for (
            int index = 1;
            index <= 10;
            index++
        ) {
            if (index == 5) {
                Console.Write(
                    "Breaking the loop at index = " + index
                );
                break;
            }

            Console.WriteLine(
                "index = " + index
            );
        }
    }
}