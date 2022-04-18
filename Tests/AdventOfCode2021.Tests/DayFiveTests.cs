using AdventOfCode2021.Core;
using AdventOfCode2021.Days;
using FluentAssertions;
using Xunit;

namespace AdventOfCode2021.Tests
{
    public class DayFiveTests
    {
        private const string exampleFilePath = "/dev/AdventOfCode2022/AdventOfCode2021/Files/DayFiveExample.txt";

        [Fact]
        public void DayFiveExample()
        {
            // Arrange
            var dayFive = new DayFive();
            var data = FileHelper.ReadFileToStringList(exampleFilePath);
            var commands = dayFive.ToModel(data);
            dayFive.PopulateBoard(commands);

            // Act
            var result = dayFive.PartOne(commands);

            // Assert
            result.Should().Be(5);
        }
    }
}
