using System;

namespace CS_Level_1_by_Programming_Advices._1_concepts._1_5_syntax._1_5_1_console_app._1_5_1_14_methods._1_5_1_14_3_default_parameter_value;

internal class DefaultParameterValue {
    public static void main(
        string[] args
    ) {
        printMessage(); // Uses default parameter
        printMessage(
            "Hello, developers!"
        ); // Overrides default parameter
    }

    private static void printMessage(
        string message = ""
    ) {
        Console.WriteLine(
            message
        );
    }
}