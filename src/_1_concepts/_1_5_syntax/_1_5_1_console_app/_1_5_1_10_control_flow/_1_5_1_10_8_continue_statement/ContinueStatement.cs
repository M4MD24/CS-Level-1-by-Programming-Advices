using System;

namespace CS_Level_1_by_Programming_Advices._1_concepts._1_5_syntax._1_5_1_console_app._1_5_1_10_control_flow._1_5_1_10_8_continue_statement;

internal class ContinueStatement {
    public static void Main(
        string[] args
    ) {
        for (
            int index = 1;
            index <= 10;
            index++
        ) {
            if (index == 5)
                continue; // Skip number 5

            Console.WriteLine(
                index
            );
        }
    }
}