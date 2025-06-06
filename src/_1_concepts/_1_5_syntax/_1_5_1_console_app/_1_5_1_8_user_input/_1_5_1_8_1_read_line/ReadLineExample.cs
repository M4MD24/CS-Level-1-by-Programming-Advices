using System;

namespace CS_Level_1_by_Programming_Advices._1_concepts._1_5_syntax._1_5_1_console_app._1_5_1_8_user_input._1_5_1_8_1_read_line;

internal class ReadLineExample {
    public static void main(
        string[] args
    ) {
        Console.Write(
            "Enter your name: "
        );
        string? name = Console.ReadLine();
        Console.Write(
            "Hello, " + name + "!"
        );
    }
}