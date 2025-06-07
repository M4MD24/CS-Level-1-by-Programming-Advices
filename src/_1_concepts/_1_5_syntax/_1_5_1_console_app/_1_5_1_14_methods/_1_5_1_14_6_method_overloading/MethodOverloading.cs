using System;

namespace CS_Level_1_by_Programming_Advices._1_concepts._1_5_syntax._1_5_1_console_app._1_5_1_14_methods._1_5_1_14_6_method_overloading;

internal class NamedArgument {
    public static void Main(
        string[] args
    ) {
        printInformation(
            "Mohamed"
        );
        printInformation(
            "Mohamed",
            22
        );
    }

    private static void printInformation(
        string name
    ) {
        Console.WriteLine(
            $"Name: {name}"
        );
    }

    private static void printInformation(
        string name,
        int    age
    ) {
        Console.WriteLine(
            $"Name: {name}, Age: {age}"
        );
    }
}