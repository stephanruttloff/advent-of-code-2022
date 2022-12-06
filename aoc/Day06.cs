using System;
using System.Text.RegularExpressions;

namespace advent_of_code_2022
{
    public static class Day06
    {
        public static int SolvePart1(string? inputOverride)
        {
            var input = inputOverride ?? File.ReadAllText("res/day06.txt");
            var locations = new HashSet<int>();
            for(int i = 0; i < input.Length; i++)
            {
                var sequence = input.Skip(i).Take(4);
                if (sequence.Distinct().Count() == 4)
                    locations.Add(i+4);
            }
            return locations.First();
        }
    }
}
