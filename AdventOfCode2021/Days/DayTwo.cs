namespace AdventOfCode2021.Days;

public class DayTwo
{
    public int PartOne(List<DayTwoModel> input)
    {
        var horizontal = 0;
        var depth = 0;
        
        foreach (var command in input)
        {
            switch (command.Command)
            {
                case "forward":
                    horizontal += command.Amount;
                    break;
                case "down":
                    depth += command.Amount;
                    break;
                case "up":
                    depth -= command.Amount;
                    break;
            }
        }
        return horizontal * depth;
    }
    
    public int PartTwo(List<DayTwoModel> input)
    {
        var horizontal = 0;
        var depth = 0;
        var aim = 0;
        
        foreach (var command in input)
        {
            switch (command.Command)
            {
                case "forward":
                    horizontal += command.Amount;
                    depth += (aim * command.Amount);
                    break;
                case "down":
                    aim += command.Amount;
                    break;
                case "up":
                    aim -= command.Amount;
                    break;
            }
        }
        return horizontal * depth;
    }
}

public class DayTwoModel
{
    public string Command { get; }
    public int Amount { get; }

    public DayTwoModel(string command, int amount)
    {
        Command = command;
        Amount = amount;
    }
}