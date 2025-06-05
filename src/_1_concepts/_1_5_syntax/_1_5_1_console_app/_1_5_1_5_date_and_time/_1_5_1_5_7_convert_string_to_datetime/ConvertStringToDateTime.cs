using System;

namespace CS_Level_1_by_Programming_Advices._1_concepts._1_5_syntax._1_5_1_console_app._1_5_1_5_date_and_time._1_5_1_5_7_convert_string_to_datetime;

internal class ConvertStringToDateTime {
    public static void Main(
        string[] args
    ) {
        string   firstText = "5/6/2025";
        DateTime firstDateTime;

        bool isValidDate = DateTime.TryParse(
            firstText,
            out firstDateTime
        );

        if (isValidDate)
            Console.WriteLine(
                firstDateTime
            );
        else
            Console.WriteLine(
                $"{firstText} isn't a valid date text"
            );

        string   secondText = "5/66/2025";
        DateTime secondDateTime;

        var isValidDate2 = DateTime.TryParse(
            secondText,
            out secondDateTime
        );

        if (isValidDate2)
            Console.WriteLine(
                secondDateTime
            );
        else
            Console.WriteLine(
                $"{secondText} isn't a valid date text"
            );
    }
}