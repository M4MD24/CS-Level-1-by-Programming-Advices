using System;

namespace CS_Level_1_by_Programming_Advices._1_concepts._1_5_syntax._1_5_1_console_app._1_5_1_10_control_flow._1_5_1_10_2_switch_statement;

internal class SwitchStatement {
    public static void Main(
        string[] args
    ) {
        Console.Write(
            "Enter a number from 1 to 3: "
        );
        int? number = Convert.ToInt32(
            Console.ReadLine()
        );

        switch (number) {
            case 1:
                Console.Write(
                    "You chose one."
                );
            break;
            case 2:
                Console.Write(
                    "You chose two."
                );
            break;
            case 3:
                Console.Write(
                    "You chose three."
                );
            break;
            default:
                Console.Write(
                    "Invalid input."
                );
            break;
        }
    }
}