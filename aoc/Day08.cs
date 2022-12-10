namespace advent_of_code_2022
{
    public static class Day08
    {
        public static int SolvePart1(string? inputOverride = null)
        {
            var layout = inputOverride?.Split(Environment.NewLine)
                ?? File.ReadAllLines("res/day08.txt");
            var grid = layout.Select(
                line => line
                    .ToCharArray()
                    .Select(height => int.Parse(height.ToString())).ToArray())
                    .ToArray();

            var visibleTrees = new List<(int x, int y)>();

            var isVisible = (int h, IEnumerable<int> o) => o.All(tree => tree < h);

            for (var x = 0; x < grid.Length; x++)
            {
                for (var y = 0; y < grid[x].Length; y++)
                {
                    if (x == 0 || x == grid.Length - 1
                    || y == 0 || y == grid[x].Length - 1)
                    {
                        visibleTrees.Add((x, y));
                        continue;
                    }

                    var height = grid[x][y];

                    var top = grid.Take(x).Select(row => row[y]);
                    var bottom = grid.Skip(x + 1).Select(row => row[y]);
                    var left = grid[x].Take(y);
                    var right = grid[x].Skip(y + 1);

                    if (top.All(tree => tree < height)
                    || bottom.All(tree => tree < height)
                    || left.All(tree => tree < height)
                    || right.All(tree => tree < height))
                    {
                        visibleTrees.Add((x, y));
                    }
                }
            }

            return visibleTrees.Count();
        }

        public static int SolvePart2(string? inputOverride = null)
        {
            throw new NotImplementedException();
        }
    }
}
