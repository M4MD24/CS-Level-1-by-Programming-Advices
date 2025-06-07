using System;

namespace CS_Level_1_by_Programming_Advices._1_concepts._1_5_syntax._1_5_1_console_app._1_5_1_14_methods._1_5_1_14_5_named_argument;

internal class NamedArgument {
    public static void Main(
        string[] args
    ) {
        printPersonInformation(
            age : 22,
            name : "Mohamed"
        );
    }

    private static void printPersonInformation(
        string name,
        int    age
    ) {
        Console.Write(
            $"Name: {name}, Age: {age}"
        );
    }
}