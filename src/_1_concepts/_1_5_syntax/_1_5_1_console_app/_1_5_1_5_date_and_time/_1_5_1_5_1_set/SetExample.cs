using System;

namespace CS_Level_1_by_Programming_Advices._1_concepts._1_5_syntax._1_5_1_console_app._1_5_1_5_date_and_time._1_5_1_5_1_set;

internal class SetExample {
    public static void Main(
        string[] args
    ) {
        DateTime specificDateTime = new DateTime(
            2025,
            6,
            5,
            16,
            17,
            1,
            424
        );

        Console.WriteLine(
            "Specific Date and Time: " +
            specificDateTime.ToString(
                "yyyy-MM-dd HH:mm:ss::fff"
            )
        );

        DateTime dateTimeNow = DateTime.Now;

        Console.WriteLine(
            "Current Date and Time: " +
            dateTimeNow.ToString(
                "yyyy-MM-dd HH:mm:ss::fff"
            )
        );
    }
}