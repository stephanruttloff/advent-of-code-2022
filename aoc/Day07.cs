﻿using System;
using System.Text.RegularExpressions;

namespace advent_of_code_2022
{
    public static class Day07
    {
        public static int SolvePart1(string? inputOverride = null)
        {
            var lines = inputOverride?.Split(Environment.NewLine)
                ?? File.ReadAllLines("res/day07.txt");

            const string cd = @"\$ cd (\w+)";
            const string cdUp = @"\$ cd \.\.";
            const string file = @"^(\d+) (.*)";

            var currentPath = new Stack<string>();
            var dirSize = new Dictionary<string, int>();

            foreach (var line in lines)
            {
                if (Regex.Match(line, cd) is var cdMatch && cdMatch.Success)
                {
                    currentPath.Push(cdMatch.Groups[1].Value);
                }
                else if (Regex.Match(line, cdUp) is var cdUpMatch && cdUpMatch.Success)
                {
                    currentPath.Pop();
                }
                else if (Regex.Match(line, file) is var fileMatch && fileMatch.Success)
                {
                    var fileSize = int.Parse(fileMatch.Groups[1].Value);

                    for (int i = 0; i <= currentPath.Count; i++)
                    {
                        var path = currentPath
                            .Skip(i)
                            .Aggregate("/", (p, d) => p + d + "/");

                        if (!dirSize.ContainsKey(path))
                            dirSize.Add(path, fileSize);
                        else
                            dirSize[path] += fileSize;
                    }
                }
            }

            return dirSize
                .Values
                .Where(x => x <= 100000)
                .Sum();
        }

        /*public static int SolvePart2(string? inputOverride = null)
        {
            
        }*/
    }
}
