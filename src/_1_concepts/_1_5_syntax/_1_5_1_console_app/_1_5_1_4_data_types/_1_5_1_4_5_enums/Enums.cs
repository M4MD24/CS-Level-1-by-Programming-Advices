using System;

namespace CS_Level_1_by_Programming_Advices._1_concepts._1_5_syntax._1_5_1_console_app._1_5_1_4_data_types._1_5_1_4_5_enums;

internal class Enums {
    private enum Days {
        Saturday,  // 0
        Sunday,    // 1
        Monday,    // 2
        Tuesday,   // 3
        Wednesday, // 4
        Thursday,  // 5
        Friday     // 6
    }

    public static void main(
        string[] args
    ) {
        Days day = Days.Friday;
        Console.Write(
            day
        );
    }
}