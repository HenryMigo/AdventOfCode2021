using AdventOfCode2021.Core;
using AdventOfCode2021.Days;
using FluentAssertions;
using System.Linq;
using Xunit;

namespace AdventOfCode2021.Tests;
public class DayTwoTests
{
    private const string filePath = "/dev/AdventOfCode2022/Files/DayTwo.txt";

    [Fact]
    public void PartOne()
    {
        // Arrange
        var dayTwo = new DayTwo();
        var dayTwoData = FileHelper.ReadFileToStringList($"{filePath}");
        var dayTwoItems = dayTwo.ConvertToModels(dayTwoData);
        
        // Act
        var dayTwoPartOneResult = dayTwo.PartOne(dayTwoItems);

        // Assert
        dayTwoPartOneResult.Should().Be(1924923);
    }

    [Fact]
    public void PartTwo()
    {
        // Arrange
        var dayTwo = new DayTwo();
        var dayTwoData = FileHelper.ReadFileToStringList($"{filePath}");
        var dayTwoItems = dayTwo.ConvertToModels(dayTwoData);

        // Act
        var dayTwoPartTwoResult = dayTwo.PartTwo(dayTwoItems);

        // Assert
        dayTwoPartTwoResult.Should().Be(1982495697);
    }
}
