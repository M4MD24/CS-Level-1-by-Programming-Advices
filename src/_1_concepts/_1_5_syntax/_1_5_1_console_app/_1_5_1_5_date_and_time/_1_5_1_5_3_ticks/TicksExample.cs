using System;

namespace CS_Level_1_by_Programming_Advices._1_concepts._1_5_syntax._1_5_1_console_app._1_5_1_5_date_and_time._1_5_1_5_3_ticks;

internal class TicksExample {
    public static void main(
        string[] args
    ) {
        Console.WriteLine(
            "Minimum Value: " + DateTime.MinValue.Ticks
        );
        Console.WriteLine(
            "Maximum Value: " + DateTime.MaxValue.Ticks
        );

        long currentTicks = DateTime.Now.Ticks;
        Console.WriteLine(
            "Current Ticks: " + currentTicks
        );

        long ticksPerDay = TimeSpan.TicksPerDay;
        Console.WriteLine(
            "Ticks per Day: " + ticksPerDay
        );

        DateTime dtFromTicks = new DateTime(
            637000000000000000
        );
        Console.WriteLine(
            "Date from Ticks: " + dtFromTicks
        );
    }
}