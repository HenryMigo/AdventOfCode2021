namespace AdventOfCode2021.Core.Models;
public class DayFourModel
{
    private List<int> _drawNumbers;
    private List<List<List<int>>> _boards;

    public DayFourModel(List<int> drawNumbers, List<List<List<int>>> boards)
    {
        _drawNumbers = drawNumbers;
        _boards = boards;
    }

    public List<int> GetDrawNumbers()
    {
        return _drawNumbers;
    }

    public void SetDrawNumbers(List<int> value)
    {
        _drawNumbers = value;
    }

    public List<List<List<int>>> GetBoards()
    {
        return _boards;
    }

    public void SetBoards(List<List<List<int>>> value)
    {
        _boards = value;
    }
}
