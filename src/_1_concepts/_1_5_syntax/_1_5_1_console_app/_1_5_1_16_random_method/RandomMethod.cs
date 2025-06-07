using System;

namespace CS_Level_1_by_Programming_Advices._1_concepts._1_5_syntax._1_5_1_console_app._1_5_1_16_random_method;

internal class RandomMethod {
    public static void Main(
        string[] args
    ) {
        Random random = new Random();

        for (
            int index = 0;
            index < 4;
            index++
        )
            Console.WriteLine(
                random.Next(
                    10,
                    20
                )
            ); // returns random integers >= 10 and < 20
    }
}