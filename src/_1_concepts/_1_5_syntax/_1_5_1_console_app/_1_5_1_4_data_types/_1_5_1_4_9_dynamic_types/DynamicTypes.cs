using System;

namespace CS_Level_1_by_Programming_Advices._1_concepts._1_5_syntax._1_5_1_console_app._1_5_1_4_data_types._1_5_1_4_9_dynamic_types;

internal class DynamicTypes {
    public static void main(
        string[] args
    ) {
        dynamic value = 10;
        Console.WriteLine(
            "Integer: " + value + ", Type: " + value.GetType()
        );

        value = "Hello, dynamic!";
        Console.WriteLine(
            "String: " + value + ", Type: " + value.GetType()
        );

        value = DateTime.Now;
        Console.WriteLine(
            "DateTime: " + value + ", Type: " + value.GetType()
        );

        value = new {
            Name = "Mohamed",
            Age  = 22
        };
        Console.WriteLine(
            "Anonymous Type: Name = " + value.Name + ", Age = " + value.Age + ", Type: " + value.GetType()
        );
    }
}