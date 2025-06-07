using System;

namespace CS_Level_1_by_Programming_Advices._1_concepts._1_5_syntax._1_5_1_console_app._1_5_1_10_control_flow._1_5_1_10_6_do_while_loop;

internal class DoWhileLoop {
    public static void main(
        string[] args
    ) {
        int number;
        do {
            Console.Write(
                "Enter a number (0 to exit): "
            );
            number = Convert.ToInt32(
                Console.ReadLine()
            );
        } while (number != 0);

        Console.Write(
            "Exited the loop."
        );
    }
}