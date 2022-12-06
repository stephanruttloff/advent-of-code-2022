namespace advent_of_code_2022
{
    public static class Day01
    {
        public static void PrintResult()
        {
            var lines = File.ReadAllLines("res/day01.txt");
            var totalCalories = new List<int>();
            var currentCalories = 0;

            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    totalCalories.Add(currentCalories);
                    currentCalories = 0;
                }
                else
                {
                    currentCalories += int.Parse(line);
                }
            }
            totalCalories.Add(currentCalories);

            var ordered = totalCalories.OrderDescending();

            Console.WriteLine($"Top 3");
            Console.WriteLine("=====");
            Console.WriteLine($"1: {ordered.ElementAt(0)}");
            Console.WriteLine($"2: {ordered.ElementAt(1)}");
            Console.WriteLine($"3: {ordered.ElementAt(2)}");
            Console.WriteLine($"Sum: {ordered.Take(3).Sum()}");
        }
    }
}
