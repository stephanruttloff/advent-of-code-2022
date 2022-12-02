namespace advent_of_code_2022
{
    public static class Day02
    {
        public static void PrintResult()
        {
            var input = File.ReadAllLines("res/day02.txt");
            var outcomes = input
                .Select(line => line.Split(" "))
                .Select(split => (int)Decode(split[1]) + (int)GetOutcome(Decode(split[1]), Decode(split[0])));
            var score = outcomes.Sum();
            Console.WriteLine($"Total score: {score}");
        }

        private static Hand Decode(string encoded) => encoded switch
        {
            "A" => Hand.Rock,
            "X" => Hand.Rock,
            "B" => Hand.Paper,
            "Y" => Hand.Paper,
            "C" => Hand.Scissors,
            "Z" => Hand.Scissors,
            _ => throw new ArgumentOutOfRangeException(nameof(encoded))
        };

        private static Outcome GetOutcome(Hand me, Hand opponent)
            => me == opponent
                ? Outcome.Draw
                : me switch
                {
                    Hand.Rock => opponent switch { Hand.Scissors => Outcome.Win, _ => Outcome.Loose },
                    Hand.Paper => opponent switch { Hand.Rock => Outcome.Win, _ => Outcome.Loose },
                    Hand.Scissors => opponent switch { Hand.Paper => Outcome.Win, _ => Outcome.Loose },
                    _ => throw new ArgumentOutOfRangeException(nameof(me)),
                };

        private enum Hand
        {
            Rock = 1,
            Paper = 2,
            Scissors = 3,
        }

        private enum Outcome
        {
            Loose = 0,
            Draw = 3,
            Win = 6,
        }
    }
}
