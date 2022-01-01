using System.Text.RegularExpressions;

namespace AdventOfCode2021.Core.Models;

public class DayFourBoardModel
{
    public DayFourBoardModel(List<string> layers)
    {
        Layers = new List<DayFourBoardItem>();

        foreach (var numbers in layers.Select(layer => layer.Split('\n').ToList()).SelectMany(numbers => numbers))
        {
            Layers.Add(new DayFourBoardItem(numbers));
        }
    }

    public List<DayFourBoardItem> Layers { get; set; }
}

public class DayFourBoardItem
{
    public List<Tuple<int, bool>> Numbers { get; set; }

    public DayFourBoardItem(string numbers)
    {
        Numbers = new List<Tuple<int, bool>>();
        numbers = Regex.Replace(numbers, @"\s+", " ").Trim();

        foreach (var number in numbers.Split(null))
        {
            Numbers.Add(new Tuple<int, bool>(int.Parse(number), false));
        }
    }
}