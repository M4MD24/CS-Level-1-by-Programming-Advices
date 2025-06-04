using System;

namespace CS_Level_1_by_Programming_Advices._1_concepts._1_5_syntax._1_5_1_console_app._1_5_1_1_output._1_5_1_1_3_formatted_string;

internal class FormattedStringExample {
    public static void main(
        string[] args
    ) {
        Console.Write(
            "{0} {1}{2}",
            "Hello",
            "Developers",
            '!'
        );
    }
}