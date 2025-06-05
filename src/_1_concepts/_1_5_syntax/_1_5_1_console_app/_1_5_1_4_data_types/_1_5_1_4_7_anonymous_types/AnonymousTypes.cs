using System;

namespace CS_Level_1_by_Programming_Advices._1_concepts._1_5_syntax._1_5_1_console_app._1_5_1_4_data_types._1_5_1_4_7_anonymous_types;

internal class AnonymousTypes {
    public static void main(
        string[] args
    ) {
        var person = new {
            name  = "Mohamed",
            age   = 22,
            major = "Android Development"
        };

        Console.WriteLine(
            "Person Information:"
        );
        Console.WriteLine(
            "Name: " + person.name
        );
        Console.WriteLine(
            "Age: " + person.age
        );
        Console.WriteLine(
            "Major: " + person.major
        );

        // You Can Create Another Anonymous Type in Anonymous Type
        var anotherPerson = new {
            name  = "Mohamed",
            age   = 22,
            major = "Software Development",
            socialModiaPlatforms = new {
                telegram = "@m4md24",
                github   = "@m4md24"
            }
        };
    }
}