using System;

namespace CS_Level_1_by_Programming_Advices._1_concepts._1_5_syntax._1_5_1_console_app._1_5_1_5_date_and_time._1_5_1_5_2_get;

internal class GetExample {
    public static void main(
        string[] args
    ) {
        DateTime now = DateTime.Now;

        Console.WriteLine(
            "Current Date and Time: " + now
        );

        Console.WriteLine(
            "Date Only: " + now.Date.ToShortDateString()
        );

        Console.WriteLine(
            "Time Only: " + now.ToShortTimeString()
        );

        Console.WriteLine(
            "Year: " + now.Year
        );
        Console.WriteLine(
            "Month: " + now.Month
        );
        Console.WriteLine(
            "Day: " + now.Day
        );
        Console.WriteLine(
            "Hour: " + now.Hour
        );
        Console.WriteLine(
            "Minute: " + now.Minute
        );
        Console.WriteLine(
            "Second: " + now.Second
        );
        Console.WriteLine(
            "Millisecond: " + now.Millisecond
        );
    }
}