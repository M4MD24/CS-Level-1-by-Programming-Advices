using System;

namespace CS_Level_1_by_Programming_Advices._1_concepts._1_5_syntax._1_5_1_console_app._1_5_1_5_date_and_time._1_5_1_5_4_static_fields;

internal class StaticFields {
    public static void Main(
        string[] args
    ) {
        DateTime currentDateTime      = DateTime.Now;
        DateTime todayDate            = DateTime.Today;
        DateTime currentDateTimeUtc   = DateTime.UtcNow;
        DateTime maximumDateTimeValue = DateTime.MaxValue;
        DateTime minimumDateTimeValue = DateTime.MinValue;

        Console.WriteLine(
            "currentDateTime: " + currentDateTime
        );
        Console.WriteLine(
            "Today: " + todayDate
        );
        Console.WriteLine(
            "currentDateTimeUTC: " + currentDateTimeUtc
        );
        Console.WriteLine(
            "minDateTimeValue: " + minimumDateTimeValue
        );
        Console.WriteLine(
            "maxDateTimeValue: " + maximumDateTimeValue
        );
    }
}