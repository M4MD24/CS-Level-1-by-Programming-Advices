using System;

namespace CS_Level_1_by_Programming_Advices._1_concepts._1_5_syntax._1_5_1_console_app._1_5_1_6_strings._1_5_1_6_1_string_methods;

internal class StringMethods {
    public static void main(
        string[] args
    ) {
        string original = "  Hello, Developers!  ";
        string trimmed  = original.Trim();

        Console.WriteLine(
            "Original: [" + original + "]"
        );
        Console.WriteLine(
            "Length: " + original.Length
        );
        Console.WriteLine(
            "Trim: [" + trimmed + "]"
        );
        Console.WriteLine(
            "TrimStart: [" + original.TrimStart() + "]"
        );
        Console.WriteLine(
            "TrimEnd: [" + original.TrimEnd() + "]"
        );
        Console.WriteLine(
            "ToUpper: " + trimmed.ToUpper()
        );
        Console.WriteLine(
            "ToLower: " + trimmed.ToLower()
        );
        Console.WriteLine(
            "Substring(2,5): " +
            trimmed.Substring(
                2,
                5
            )
        );
        Console.WriteLine(
            "Replace(\"developers\", \"C#\"): " +
            trimmed.Replace(
                "developers",
                "C#"
            )
        );
        Console.WriteLine(
            "IndexOf(\"o\"): " +
            trimmed.IndexOf(
                'o'
            )
        );
        Console.WriteLine(
            "LastIndexOf(\"l\"): " +
            trimmed.LastIndexOf(
                'l'
            )
        );
        Console.WriteLine(
            "Contains(\"developers\"): " +
            trimmed.Contains(
                "developers"
            )
        );
        Console.WriteLine(
            "StartsWith(\"Hello\"): " +
            trimmed.StartsWith(
                "Hello"
            )
        );
        Console.WriteLine(
            "EndsWith(\"!\"): " +
            trimmed.EndsWith(
                "!"
            )
        );
        Console.WriteLine(
            "Equals(\"Hello, developers!\"): " +
            trimmed.Equals(
                "Hello, developers!"
            )
        );
        Console.WriteLine(
            "Equals (ignore case): " +
            trimmed.Equals(
                "hello, developers!",
                StringComparison.OrdinalIgnoreCase
            )
        );
        Console.WriteLine(
            "IsNullOrEmpty: " +
            string.IsNullOrEmpty(
                trimmed
            )
        );
        Console.WriteLine(
            "IsNullOrWhiteSpace: " +
            string.IsNullOrWhiteSpace(
                original
            )
        );
        Console.WriteLine(
            "Remove(5): " +
            trimmed.Remove(
                5
            )
        );
        Console.WriteLine(
            "Remove(2,3): " +
            trimmed.Remove(
                2,
                3
            )
        );
        Console.WriteLine(
            "Insert(5, \" C#\"): " +
            trimmed.Insert(
                5,
                " C#"
            )
        );
        Console.WriteLine(
            "PadLeft(20): [" +
            trimmed.PadLeft(
                20
            ) +
            "]"
        );
        Console.WriteLine(
            "PadRight(20): [" +
            trimmed.PadRight(
                20
            ) +
            "]"
        );
        Console.WriteLine(
            "ToCharArray: " +
            string.Join(
                ",",
                trimmed.ToCharArray()
            )
        );
        Console.WriteLine(
            "Compare(\"Hello\", \"developers\"): " +
            string.CompareOrdinal(
                "Hello",
                "developers"
            )
        );
        Console.WriteLine(
            "Format: " +
            string.Format(
                "Welcome {0}!",
                "User"
            )
        );
        Console.WriteLine(
            "Concat: " +
            string.Concat(
                "C#",
                " ",
                "Programming"
            )
        );
        Console.WriteLine(
            "Normalize: " + "é".Normalize()
        );
        Console.WriteLine(
            "GetHashCode: " + trimmed.GetHashCode()
        );
        Console.WriteLine(
            "Clone: " + trimmed.Clone()
        );

        string[] parts = trimmed.Split(
            ','
        );
        Console.WriteLine(
            "Split: " +
            string.Join(
                "|",
                parts
            )
        );

        string joined = string.Join(
            "-",
            parts
        );
        Console.WriteLine(
            "Join: " + joined
        );
    }
}