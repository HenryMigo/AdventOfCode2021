namespace AdventOfCode2021.Core.Models;

public class DayFourModel
{
    private string BingoSequence { get; }
    public List<DayFourBoardModel> Boards { get; }

    public DayFourModel(string bingoSequence, List<DayFourBoardModel> boards)
    {
        BingoSequence = bingoSequence;
        Boards = boards;
    }
}