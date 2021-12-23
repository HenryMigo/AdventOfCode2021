namespace AdventOfCode2021.Core.Models;

public class DayFourBoardModel
{
    public DayFourBoardModel(List<string> layers)
    {
        Layers = layers;
    }

    public List<string> Layers { get; set; }
}