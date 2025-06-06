using System;

namespace CS_Level_1_by_Programming_Advices._1_concepts._1_5_syntax._1_5_1_console_app._1_5_1_7_casting_types._1_5_1_7_3_type_conversion_methods;

internal class TypeConversionMethods {
    public static void main(
        string[] args
    ) {
        // Example 1: Using Convert class
        string numberString = "123";
        int number = Convert.ToInt32(
            numberString
        );
        Console.WriteLine(
            "Converted using Convert.ToInt32: " + number
        );

        // Example 2: Using int.Parse
        int parsedNumber = int.Parse(
            numberString
        );
        Console.WriteLine(
            "Converted using int.Parse: " + parsedNumber
        );

        // Example 3: Using int.TryParse
        string invalidNumber = "abc";
        bool success = int.TryParse(
            invalidNumber,
            out int result
        );
        Console.WriteLine(
            $"TryParse success: {success}, Result: {result}"
        );
    }
}