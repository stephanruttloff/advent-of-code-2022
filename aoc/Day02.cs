namespace advent_of_code_2022
{
    public static class Day02
    {
        public static void PrintResult()
        {
            var input = File.ReadAllLines("res/day02.txt");
            var outcomes = input
                .Select(line => line.Split(" "))
                .Select(split => new[] { ToHand(split[0]), GetHand(ToHand(split[0]), ToOutcome(split[1])) })
                .Select(hands => (int)hands[1] + (int)GetOutcome(hands[1], hands[0]));
            var score = outcomes.Sum();
            Console.WriteLine($"Total score: {score}");
        }

        private static Hand ToHand(string encoded) => encoded switch
        {
            "A" => Hand.Rock,
            "B" => Hand.Paper,
            "C" => Hand.Scissors,
            _ => throw new ArgumentOutOfRangeException(nameof(encoded))
        };

        private static Outcome ToOutcome(string encoded) => encoded switch
        {
            "X" => Outcome.Loose,
            "Y" => Outcome.Draw,
            "Z" => Outcome.Win,
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

        private static Hand GetHand(Hand opponent, Outcome outcome)
            => outcome == Outcome.Draw
            ? opponent
            : opponent switch
            {
                Hand.Rock => outcome switch { Outcome.Win => Hand.Paper, _ => Hand.Scissors },
                Hand.Paper => outcome switch { Outcome.Win => Hand.Scissors, _ => Hand.Rock },
                Hand.Scissors => outcome switch { Outcome.Win => Hand.Rock, _ => Hand.Paper },
                _ => throw new ArgumentOutOfRangeException(nameof(opponent)),
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
