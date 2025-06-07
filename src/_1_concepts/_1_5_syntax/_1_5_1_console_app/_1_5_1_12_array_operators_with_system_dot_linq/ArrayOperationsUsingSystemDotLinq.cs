using System;
using System.Linq;

namespace CS_Level_1_by_Programming_Advices._1_concepts._1_5_syntax._1_5_1_console_app._1_5_1_12_array_operators_with_system_dot_linq;

internal class ArrayOperationsUsingSystemDotLinq {
    public static void main(
        string[] args
    ) {
        int[] numbers = [
            1,
            2,
            3,
            4,
            5,
            6,
            2,
            3
        ];

        Console.WriteLine(
            "Original Array: " +
            string.Join(
                ", ",
                numbers
            )
        );

        // Filtering
        Console.WriteLine(
            "Where (Even): " +
            string.Join(
                ", ",
                numbers.Where(
                    number => number % 2 == 0
                )
            )
        );

        // Transformation
        Console.WriteLine(
            "Select (Square): " +
            string.Join(
                ", ",
                numbers.Select(
                    number => number * number
                )
            )
        );

        // Aggregation
        Console.WriteLine(
            "Sum: " + numbers.Sum()
        );
        Console.WriteLine(
            "Average: " + numbers.Average()
        );
        Console.WriteLine(
            "Max: " + numbers.Max()
        );
        Console.WriteLine(
            "Min: " + numbers.Min()
        );

        // Element operations
        Console.WriteLine(
            "First: " + numbers.First()
        );
        Console.WriteLine(
            "FirstOrDefault: " +
            numbers.FirstOrDefault(
                number => number > 10
            )
        );
        Console.WriteLine(
            "Last: " + numbers.Last()
        );
        Console.WriteLine(
            "LastOrDefault: " +
            numbers.LastOrDefault(
                number => number < 0
            )
        );
        Console.WriteLine(
            "Single (==5): " +
            numbers.SingleOrDefault(
                number => number == 5
            )
        );

        // Quantifiers
        Console.WriteLine(
            "All > 0: " +
            numbers.All(
                number => number > 0
            )
        );
        Console.WriteLine(
            "Any == 5: " +
            numbers.Any(
                number => number == 5
            )
        );
        Console.WriteLine(
            "Contains 4: " +
            numbers.Contains(
                4
            )
        );

        // Set operations
        Console.WriteLine(
            "Distinct: " +
            string.Join(
                ", ",
                numbers.Distinct()
            )
        );
        Console.WriteLine(
            "Skip(2): " +
            string.Join(
                ", ",
                numbers.Skip(
                    2
                )
            )
        );
        Console.WriteLine(
            "Take(3): " +
            string.Join(
                ", ",
                numbers.Take(
                    3
                )
            )
        );

        // Ordering
        Console.WriteLine(
            "OrderBy: " +
            string.Join(
                ", ",
                numbers.OrderBy(
                    number => number
                )
            )
        );
        Console.WriteLine(
            "OrderByDescending: " +
            string.Join(
                ", ",
                numbers.OrderByDescending(
                    number => number
                )
            )
        );

        // Grouping (Grouped by remainder when divided by 2)
        var groups = numbers.GroupBy(
            number => number % 2
        );
        foreach (var group in groups) {
            Console.WriteLine(
                "Group Key: " +
                group.Key     +
                " => "        +
                string.Join(
                    ", ",
                    group
                )
            );
        }

        // Reverse
        Console.WriteLine(
            "Reversed: " +
            string.Join(
                ", ",
                numbers.Reverse()
            )
        );

        // ToArray
        int[] arrayAgain = numbers.ToArray();

        // ToList
        var list = numbers.ToList();
        Console.WriteLine(
            "ToList: " +
            string.Join(
                ", ",
                list
            )
        );
    }
}