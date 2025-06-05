using System;

namespace CS_Level_1_by_Programming_Advices._1_concepts._1_5_syntax._1_5_1_console_app._1_5_1_5_date_and_time._1_5_1_5_5_time_span;

internal class TimeSpanExample {
    public static void Main(
        string[] args
    ) {
        DateTime current = DateTime.Now;

        Console.WriteLine(
            current
        );

        TimeSpan timeSpan = new TimeSpan(
            49,
            25,
            34
        );

        Console.WriteLine(
            "TimeSpan: " + timeSpan
        );

        Console.WriteLine(
            "TimeSpan Days: " + timeSpan.Days
        );
        Console.WriteLine(
            "TimeSpan Hours: " + timeSpan.Hours
        );
        Console.WriteLine(
            "TimeSpan Minutes: " + timeSpan.Minutes
        );
        Console.WriteLine(
            "TimeSpan Seconds: " + timeSpan.Seconds
        );

        Console.WriteLine(
            "After Add: " +
            current.Add(
                timeSpan
            )
        );

        Console.WriteLine(
            "After Subtract: " +
            current.Subtract(
                timeSpan
            )
        );
    }
}