using System;

namespace CS_Level_1_by_Programming_Advices._1_concepts._1_5_syntax._1_5_1_console_app._1_5_1_8_user_input._1_5_1_8_2_input_number;

internal class InputNumberExample {
    public static void Main(
        string[] args
    ) {
        Console.Write(
            "Enter your age: "
        );
        // if you dont convert you will get error, and if you enter string you will get error
        int age = Convert.ToInt32(
            Console.ReadLine()
        );
        Console.Write(
            "Your age is: " + age
        );
    }
}