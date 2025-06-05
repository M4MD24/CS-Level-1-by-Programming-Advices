using System;

namespace CS_Level_1_by_Programming_Advices._1_concepts._1_5_syntax._1_5_1_console_app._1_5_1_4_data_types._1_5_1_4_8_structures;

internal class Structures {
    private struct Person {
        public string firstName,
                      secondName;
    }

    public static void Main(
        string[] args
    ) {
        Person person;

        person.firstName  = "Mohammed";
        person.secondName = "Sadawy";

        Console.WriteLine(
            person.firstName
        );
        Console.WriteLine(
            person.secondName
        );

        Person anotherPerson = new Person {
            firstName  = "Mohamed",
            secondName = "Sadawy"
        };
    }
}