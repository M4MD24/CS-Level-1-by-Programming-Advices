using System;

namespace CS_Level_1_by_Programming_Advices._1_concepts._1_5_syntax._1_5_1_console_app._1_5_1_10_control_flow._1_5_1_10_1_if_condition;

internal class IfCondition {
    public static void main(
        string[] args
    ) {
        Console.Write(
            "Enter Number: "
        );
        int? number = Convert.ToInt32(
            Console.ReadLine()
        );

        if (number == 0)
            Console.Write(
                "Zero"
            );
        else if (number > 0)
            Console.Write(
                "Positive"
            );
        else
            Console.Write(
                "Negative"
            );
    }
}