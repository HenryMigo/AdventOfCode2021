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
        var data = File.ReadLines(fileLocation).ToList();
        var dayFourModel = new DayFourModel(data[0],new List<DayFourBoardModel>());

        for (var i = 1; i < data.Count; i += 6)
        {
            if (data[i] == string.Empty)
            {
                dayFourModel.Boards.Add(new DayFourBoardModel
                (
                    new List<string>
                    {
                        data[i + 1],
                        data[i + 2],
                        data[i + 3],
                        data[i + 4],
                        data[i + 5]
                    }
                ));
            }
        }

        return dayFourModel;
    }
}