using System;

namespace CS_Level_1_by_Programming_Advices._1_concepts._1_5_syntax._1_5_1_console_app._1_5_1_15_exceptions;

internal class ExceptionsExample {
    public static void main(
        string[] args
    ) {
        try {
            int number = Convert.ToInt32(
                Console.ReadLine()
            );
            Console.WriteLine(
                $"Exception caught: {number}"
            );
        } catch (Exception exception) {
            Console.WriteLine(
                $"Exception caught: {exception.Message}"
            );
        } finally {
            Console.Write(
                "Complete!"
            );
        }
    }
}