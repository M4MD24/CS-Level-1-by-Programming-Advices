using System;

namespace CS_Level_1_by_Programming_Advices._1_concepts._1_5_syntax._1_5_1_console_app._1_5_1_10_control_flow._1_5_1_10_5_while_loop;

internal class WhileLoop {
    public static void main(
        string[] args
    ) {
        int index = 1;
        while (index <= 5)
            Console.WriteLine(
                index++
            );
    }
}