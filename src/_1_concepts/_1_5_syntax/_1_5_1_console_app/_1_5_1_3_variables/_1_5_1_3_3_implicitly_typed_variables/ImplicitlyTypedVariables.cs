using System;

namespace CS_Level_1_by_Programming_Advices._1_concepts._1_5_syntax._1_5_1_console_app._1_5_1_3_variables._1_5_1_3_3_implicitly_typed_variables;

internal class ImplicitlyTypedVariables {
    public static void Main(
        string[] args
    ) {
        var firstNumber = 10;
        // Note: You Must Set Initialized Value for Var Variable
        /*
         * Error:
         * var firstNumber;
         */
        Console.Write(
            "First Number: {0}",
            firstNumber
        );
    }
}