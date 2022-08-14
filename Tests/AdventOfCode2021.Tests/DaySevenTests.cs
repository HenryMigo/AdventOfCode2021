using AdventOfCode2021.Days;
using FluentAssertions;
using Xunit;

namespace AdventOfCode2021.Tests;

public class DaySevenTests
{
    [Theory]
    [InlineData("16,1,2,0,4,2,7,1,2,14")]
    public void TestDate(string testData)
    {
        // Arrange
        var daySeven = new DaySeven();

        // Act
        var cost = daySeven.GetCheapestFuelCost(testData);

        // Assert
        cost.Should().Be(37);
    }
}