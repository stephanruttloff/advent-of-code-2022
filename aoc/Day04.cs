using System;
using System.Text.RegularExpressions;

namespace advent_of_code_2022
{
    public static class Day04
    {
        public static void PrintResult()
        {
            var part1 = File.ReadAllLines("res/day04.txt")
                .Select(line => Regex.Match(line, "(\\d+)-(\\d+),(\\d+)-(\\d+)"))
                .Select(match => new[] {
                    (start: int.Parse(match.Groups[1].Value), end: int.Parse(match.Groups[2].Value)),
                    (start: int.Parse(match.Groups[3].Value), end: int.Parse(match.Groups[4].Value)),
                })
                .Where(pairs =>
                    pairs[0].start >= pairs[1].start && pairs[0].end <= pairs[1].end ||
                    pairs[1].start >= pairs[0].start && pairs[1].end <= pairs[0].end)
                .Count();
            Console.WriteLine($"Solution: {part1}");

            var part2 = File.ReadAllLines("res/day04.txt")
                .Select(line => Regex.Match(line, "(\\d+)-(\\d+),(\\d+)-(\\d+)"))
                .Select(match => new[] {
                    (start: int.Parse(match.Groups[1].Value), end: int.Parse(match.Groups[2].Value)),
                    (start: int.Parse(match.Groups[3].Value), end: int.Parse(match.Groups[4].Value)),
                })
                .Select(pairs => new[]
                {
                    Enumerable.Range(pairs[0].start, pairs[0].end-pairs[0].start+1),
                    Enumerable.Range(pairs[1].start, pairs[1].end-pairs[1].start+1),
                })
                .Select(ranges => ranges[0].Intersect(ranges[1]))
                .Where(overlap => overlap.Any())
                .Count();
            Console.WriteLine($"Solution: {part2}");
        }
    }
}
