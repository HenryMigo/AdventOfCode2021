using AdventOfCode2021.Core;
using AdventOfCode2021.Days;
using FluentAssertions;
using System.Linq;
using Xunit;

namespace AdventOfCode2021.Tests;
public class DayOneTests
{
    private const string filePath = "/dev/AdventOfCode2022/Files/DayOne.txt";

    [Fact]
    public void PartOne()
    {
        // Arrange
        var dayOne = new DayOne();
        var dayOneData = FileHelper.ReadFileToIntArray($"{filePath}");

        var oneData = dayOneData as int[] ?? dayOneData.ToArray();

        // Act
        var dayOnePartOneResults = dayOne.PartOne(oneData);

        // Assert
        dayOnePartOneResults.Item1.Should().Be(1655);
    }

    [Fact]
    public void PartTwo()
    {
        // Arrange
        var dayOne = new DayOne();
        var dayOneData = FileHelper.ReadFileToIntArray($"{filePath}");

        var oneData = dayOneData as int[] ?? dayOneData.ToArray();

        // Act
        var dayOnePartTwoResults = dayOne.PartTwo(oneData);

        // Assert
        dayOnePartTwoResults.Item1.Should().Be(1683);
    }
}
