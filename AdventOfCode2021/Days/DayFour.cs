using AdventOfCode2021.Core.Models;

namespace AdventOfCode2021.Days;

public class DayFour
{
    public int PartOne(DayFourModel data)
    {
        var random = new Random();
        var isGameOver = false;

        while (!isGameOver)
        {
            var amountToDraw = random.Next(data.BingoSequence.Count);

            for (var i = 0; i < amountToDraw; i++)
            {

            }
        }

        return 0;
    }

    public int PartTwo(DayFourModel data)
    {
        return 0;
    }
}