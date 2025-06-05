using System;

namespace CS_Level_1_by_Programming_Advices._1_concepts._1_5_syntax._1_5_1_console_app._1_5_1_5_date_and_time._1_5_1_5_6_operators;

internal class OperatorsExample {
    public static void main(
        string[] args
    ) {
        DateTime firstDateTime = new DateTime(
            2015,
            12,
            20
        );
        DateTime secondDateTime = new DateTime(
            2016,
            12,
            31,
            5,
            10,
            20
        );
        TimeSpan timeSpan = new TimeSpan(
            10,
            5,
            25,
            50
        );

        Console.WriteLine(
            "+  " + (secondDateTime + timeSpan)
        );
        Console.WriteLine(
            "-  " + (secondDateTime - firstDateTime)
        );
        Console.WriteLine(
            "== " + (firstDateTime == secondDateTime)
        );
        Console.WriteLine(
            "!= " + (firstDateTime != secondDateTime)
        );
        Console.WriteLine(
            ">  " + (firstDateTime > secondDateTime)
        );
        Console.WriteLine(
            "<  " + (firstDateTime < secondDateTime)
        );
        Console.WriteLine(
            ">= " + (firstDateTime >= secondDateTime)
        );
        Console.WriteLine(
            "<= " + (firstDateTime <= secondDateTime)
        );
    }
}