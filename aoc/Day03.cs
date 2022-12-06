using System;
namespace advent_of_code_2022
{
    public static class Day03
    {
        public static void PrintResult()
        {
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

            var part1 = File.ReadAllLines("res/day03.txt")
                .Select(line => new[] { line[..(line.Length / 2)], line[(line.Length / 2)..] })
                .Select(lineParts => lineParts[0].First(c => lineParts[1].Contains(c)))
                .Select(commonElement => chars.IndexOf(commonElement) + 1)
                .Sum();

            Console.WriteLine($"Answer part 1: {part1}");

            var part2 = File.ReadAllLines("res/day03.txt")
                .Chunk(3)
                .Select(group => group[0].First(c => group[1].Contains(c) && group[2].Contains(c)))
                .Select(commonElement => chars.IndexOf(commonElement) + 1)
                .Sum();

            Console.WriteLine($"Answer part 2: {part2}");
        }
    }
}

