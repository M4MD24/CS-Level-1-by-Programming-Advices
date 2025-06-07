using System;

namespace CS_Level_1_by_Programming_Advices._1_concepts._1_5_syntax._1_5_1_console_app._1_5_1_10_control_flow._1_5_1_10_4_for_loop;

internal class ForLoop {
    public static void Main(
        string[] args
    ) {
        for (
            int index = 1;
            index <= 5;
            index++
        )
            Console.WriteLine(
                index
            );
    }
}