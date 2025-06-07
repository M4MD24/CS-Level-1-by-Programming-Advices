using System;

namespace CS_Level_1_by_Programming_Advices._1_concepts._1_5_syntax._1_5_1_console_app._1_5_1_11_arrays._1_5_1_11_4_access_array_elements;

internal class AccessArrayElements {
    public static void Main(
        string[] args
    ) {
        int[] numbers = [
            10,
            20,
            30,
            40,
            50
        ];

        // Accessing individual elements using index
        Console.WriteLine(
            "First element: " + numbers[0]
        );
        Console.WriteLine(
            "Third element: " + numbers[2]
        );
        Console.WriteLine( // // Print the last element using the ^ operator (index from end)
            "Last element: " + numbers[^1]
        );
    }
}