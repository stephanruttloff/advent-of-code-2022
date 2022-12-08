namespace Tests;

public class Day07
{
    [Fact]
    public void Part1()
    {
        const string input = @"
$ cd /
$ ls
dir a
14848514 b.txt
8504156 c.dat
dir d
$ cd a
$ ls
dir e
29116 f
2557 g
62596 h.lst
$ cd e
$ ls
584 i
$ cd ..
$ cd ..
$ cd d
$ ls
4060174 j
8033020 d.log
5626152 d.ext
7214296 k";

        Assert.Equal(95437, advent_of_code_2022.Day07.SolvePart1(input));
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
