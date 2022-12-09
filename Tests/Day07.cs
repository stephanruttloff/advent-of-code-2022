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
        Assert.Equal(1908462, advent_of_code_2022.Day07.SolvePart1(File.ReadAllText("res/day07.txt")));
    }

    [Fact]
    public void Part2()
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

        Assert.Equal(24933642, advent_of_code_2022.Day07.SolvePart2(input));
    }
}
