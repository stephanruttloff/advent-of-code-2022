using System;
namespace advent_of_code_2022
{
    public static class Day03
    {
        public static void PrintResult()
        {
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

            var sum = File.ReadAllLines("res/day03.txt")
                .Select(line => new[] {line[..(line.Length / 2)], line[(line.Length / 2)..] })
                .Select(lineParts => lineParts[0].First(c => lineParts[1].Contains(c)))
                .Select(commonElement => chars.IndexOf(commonElement) + 1)
                .Sum();

            Console.WriteLine($"Sum is {sum}");
        }
    }
}

