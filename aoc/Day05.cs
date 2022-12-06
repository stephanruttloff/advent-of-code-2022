using System;
using System.Text.RegularExpressions;

namespace advent_of_code_2022
{
    public static class Day05
    {
        public static void PrintResult()
        {
            const string stacksRegex = "(?: ?\\[(.)\\] ?|( {3}))";
            const string commandRegex = "move (\\d+) from (\\d+) to (\\d+)";

            var lines = File.ReadAllLines("res/day05.txt");

            var stacks = lines
                .Where(line => line.Contains('['))
                .Select(line => Regex.Matches(line, stacksRegex))
                .Aggregate(new List<string>[9], (stacks, matches) =>
                {
                    for (var i = 0; i < 9; i++)
                    {
                        var value = matches[i].Groups[1].Value;
                        if (string.IsNullOrWhiteSpace(value)) continue;
                        if (stacks[i] == null) stacks[i] = new List<string>();
                        stacks[i].Add(value);
                    }

                    return stacks;
                });
            var commands = lines
                .Where(line => line.StartsWith("move"))
                .Select(line => Regex.Match(line, commandRegex))
                .Select(match => new
                {
                    amount = int.Parse(match.Groups[1].Value),
                    from = int.Parse(match.Groups[2].Value),
                    to = int.Parse(match.Groups[3].Value),
                });

            foreach (var command in commands)
            {
                stacks[command.to - 1].InsertRange(
                    0, stacks[command.from - 1].Take(command.amount));
                stacks[command.from - 1].RemoveRange(0, command.amount);
            }

            var result = stacks
                .Select(stack => stack.First())
                .Aggregate("", (r, c) => r + c);

            Console.WriteLine($"Result: {result}");
        }
    }
}
