using System;

namespace CS_Level_1_by_Programming_Advices._1_concepts._1_5_syntax._1_5_1_console_app._1_5_1_1_output._1_5_1_1_4_escape_characters;

internal class EscapeCharacters {
    public static void main(
        string[] args
    ) {
        Console.WriteLine(
            "New Line: Hello\nWorld"
        );

        Console.WriteLine(
            "Tab: Hello\tWorld"
        );

        Console.WriteLine(
            "Backslash: C:\\Program Files\\MyApp"
        );

        Console.WriteLine(
            "Single Quote: It\'s a sunny day."
        );

        Console.WriteLine(
            "Double Quote: He said, \"Hello!\""
        );

        Console.WriteLine(
            "Backspace: Hello\bWorld"
        );

        Console.WriteLine(
            "Carriage Return: First Line\rSecond"
        );

        Console.WriteLine(
            "Carriage Return: First Line\aSecond"
        );
    }
}