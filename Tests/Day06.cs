namespace Tests;

public class Day06
{
    [Fact]
    public void Part1()
    {
        Assert.Equal(5, advent_of_code_2022.Day06.SolvePart1("bvwbjplbgvbhsrlpgdmjqwftvncz"));
        Assert.Equal(6, advent_of_code_2022.Day06.SolvePart1("nppdvjthqldpwncqszvftbrmjlhg"));
        Assert.Equal(10, advent_of_code_2022.Day06.SolvePart1("nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg"));
        Assert.Equal(11, advent_of_code_2022.Day06.SolvePart1("zcfzfwzzqfrljwzlrfnpqdbhtmscgvjw"));
    }

    [Fact]
    public void Part2()
    {
        Assert.Equal(19, advent_of_code_2022.Day06.SolvePart2("mjqjpqmgbljsphdztnvjfqwrcgsmlb"));
        Assert.Equal(23, advent_of_code_2022.Day06.SolvePart2("bvwbjplbgvbhsrlpgdmjqwftvncz"));
        Assert.Equal(23, advent_of_code_2022.Day06.SolvePart2("nppdvjthqldpwncqszvftbrmjlhg"));
        Assert.Equal(29, advent_of_code_2022.Day06.SolvePart2("nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg"));
        Assert.Equal(26, advent_of_code_2022.Day06.SolvePart2("zcfzfwzzqfrljwzlrfnpqdbhtmscgvjw"));
    }
}
