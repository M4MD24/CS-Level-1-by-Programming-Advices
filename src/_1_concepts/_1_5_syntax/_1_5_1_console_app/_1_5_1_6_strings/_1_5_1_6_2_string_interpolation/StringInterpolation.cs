using System;

namespace CS_Level_1_by_Programming_Advices._1_concepts._1_5_syntax._1_5_1_console_app._1_5_1_6_strings._1_5_1_6_2_string_interpolation;

internal class StringInterpolation {
    public static void Main(
        string[] args
    ) {
        string name    = "Mohamed";
        int    age     = 22;
        string message = $"Hello, My name is {name} and I'm {age} years old.";
        Console.Write(
            message
        );
    }
}