using System;

namespace CS_Level_1_by_Programming_Advices._1_concepts._1_5_syntax._1_5_1_console_app._1_5_1_13_math;

internal class MathExample {
    public static void Main(
        string[] args
    ) {
        double firstNumber  = 7.5,
               secondNumber = 2.3,
               thirdNumber  = -4.7;

        Console.WriteLine(
            $"Math.Abs({thirdNumber}) = " +
            Math.Abs(
                thirdNumber
            )
        ); // absolute value
        Console.WriteLine(
            $"Math.Ceiling({firstNumber}) = " +
            Math.Ceiling(
                firstNumber
            )
        ); // smallest int >= a
        Console.WriteLine(
            $"Math.Floor({firstNumber}) = " +
            Math.Floor(
                firstNumber
            )
        ); // largest int <= a
        Console.WriteLine(
            $"Math.Round({firstNumber}) = " +
            Math.Round(
                firstNumber
            )
        ); // rounds to nearest int
        Console.WriteLine(
            $"Math.Truncate({firstNumber}) = " +
            Math.Truncate(
                firstNumber
            )
        ); // removes fractional part

        Console.WriteLine(
            $"Math.Max({firstNumber}, {secondNumber}) = " +
            Math.Max(
                firstNumber,
                secondNumber
            )
        ); // max of two
        Console.WriteLine(
            $"Math.Min({firstNumber}, {secondNumber}) = " +
            Math.Min(
                firstNumber,
                secondNumber
            )
        ); // min of two

        Console.WriteLine(
            $"Math.Pow({firstNumber}, {secondNumber}) = " +
            Math.Pow(
                firstNumber,
                secondNumber
            )
        ); // a^b power
        Console.WriteLine(
            $"Math.Sqrt({firstNumber}) = " +
            Math.Sqrt(
                firstNumber
            )
        ); // square root

        Console.WriteLine(
            $"Math.Log({firstNumber}) = " +
            Math.Log(
                firstNumber
            )
        ); // natural log (base e)
        Console.WriteLine(
            $"Math.Log10({firstNumber}) = " +
            Math.Log10(
                firstNumber
            )
        ); // log base 10

        Console.WriteLine(
            $"Math.Exp({secondNumber}) = " +
            Math.Exp(
                secondNumber
            )
        ); // e^b exponential

        Console.WriteLine(
            $"Math.Sin({firstNumber}) = " +
            Math.Sin(
                firstNumber
            )
        ); // sine
        Console.WriteLine(
            $"Math.Cos({firstNumber}) = " +
            Math.Cos(
                firstNumber
            )
        ); // cosine
        Console.WriteLine(
            $"Math.Tan({firstNumber}) = " +
            Math.Tan(
                firstNumber
            )
        ); // tangent

        Console.WriteLine(
            $"Math.Asin({0.5}) = " +
            Math.Asin(
                0.5
            )
        ); // arcsin (returns radians)
        Console.WriteLine(
            $"Math.Acos({0.5}) = " +
            Math.Acos(
                0.5
            )
        ); // arccos (returns radians)
        Console.WriteLine(
            "Math.Atan(1) = " +
            Math.Atan(
                1
            )
        ); // arctan (returns radians)

        Console.WriteLine(
            $"Math.PI = {Math.PI}"
        ); // PI constant
        Console.WriteLine(
            $"Math.E = {Math.E}"
        ); // Euler’s number constant
    }
}