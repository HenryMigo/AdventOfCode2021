using AdventOfCode2021.Core.Models;

namespace AdventOfCode2021.Core;

public static class FileHelper
{
    public static IEnumerable<int> ReadFileToIntArray(string fileLocation)
    {
        var text = File.ReadAllLines(fileLocation);

        return text.Select(int.Parse).ToList();
    }

    public static IEnumerable<string> ReadFileToStringList(string fileLocation)
    {
        var text = File.ReadAllLines(fileLocation);

        return text.ToList();
    }

    public static DayFourModel ReadFileToBingo(string fileLocation)
    {
        var boards = new List<List<List<int>>>();

        var data = File.ReadLines(fileLocation).ToList();
        var numberOfBoards = (data.Count - 1) / 6;

        var drawNumbers = data[0].Split(',').Select(int.Parse).ToList();
        
        for (var i = 0; i < numberOfBoards; i++)
        {
            var board = new List<List<int>>();

            for(var row = 0; row < 5; row++)
            {
                board.Add(data[2 + 6 * i + row].Split().Where(x => x.Trim() != string.Empty).Select(int.Parse).ToList());
            }

            boards.Add(board);
        }

        return new DayFourModel(drawNumbers, boards);
    }
}