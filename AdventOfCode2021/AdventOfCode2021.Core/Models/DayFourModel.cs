namespace AdventOfCode2021.Core.Models;

public class DayFourModel
{
    public List<string> BingoSequence { get; }
    public List<DayFourBoardModel> Boards { get; }

    public DayFourModel(List<string> bingoSequence, List<DayFourBoardModel> boards)
    {
        BingoSequence = bingoSequence;
        Boards = boards;
    }
}