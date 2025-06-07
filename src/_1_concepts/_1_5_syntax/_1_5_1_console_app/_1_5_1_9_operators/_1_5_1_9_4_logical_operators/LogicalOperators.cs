using System;

namespace CS_Level_1_by_Programming_Advices._1_concepts._1_5_syntax._1_5_1_console_app._1_5_1_9_operators._1_5_1_9_4_logical_operators;

internal class LogicalOperators {
    public static void main(
        string[] args
    ) {
        bool isAdult   = true;
        bool hasTicket = false;

        Console.WriteLine(
            "Can enter (AND): " + (isAdult && hasTicket)
        );

        Console.WriteLine(
            "Can enter (OR): " + (isAdult || hasTicket)
        );

        Console.WriteLine(
            "Does NOT have ticket: " + !hasTicket
        );
    }
}