using AdventOfCode2021.Core.Models;

namespace AdventOfCode2021.Days;

public class DayFour
{
    public int PartOne(DayFourModel dayFourModel)
    {
        foreach(var number in dayFourModel.GetDrawNumbers())
        {
            MarkBingoBoards(dayFourModel, number);

            foreach(var board in dayFourModel.GetBoards())
            {
                for(var i = 0; i < 5; i++)
                {
                    if(board[i].Sum() == -5 || board.Select(x => x[i]).Sum() == -5)
                    {
                        return board.SelectMany(x => x).Where(x => x != -1).Sum() * number;
                    }
                }
            }
        }

        return 0;
    }

    public int PartTwo(DayFourModel dayFourModel)
    {
        var finalScore = 0;

        foreach (var number in dayFourModel.GetDrawNumbers())
        {
            MarkBingoBoards(dayFourModel, number);

            var winningBoards = new List<List<List<int>>>();

            foreach (var board in dayFourModel.GetBoards())
            {
                for (var i = 0; i < 5; i++)
                {
                    if (board[i].Sum() == -5 || board.Select(x => x[i]).Sum() == -5)
                    {
                        finalScore = board.SelectMany(x => x).Where(x => x != -1).Sum() * number;
                        winningBoards.Add(board);
                    }
                }
            }

            foreach (var board in winningBoards)
            {
                dayFourModel.GetBoards().Remove(board);
            }
        }

        return finalScore;
    }

    private static void MarkBingoBoards(DayFourModel dayFourModel, int number)
    {
        foreach (var board in dayFourModel.GetBoards())
        {
            for (var i = 0; i < 5; i++)
            {
                for (var y = 0; y < 5; y++)
                {
                    if (board[i][y] == number)
                    {
                        board[i][y] = -1;
                    }
                }
            }
        }
    }
}