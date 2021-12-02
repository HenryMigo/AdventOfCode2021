namespace AdventOfCode2021;

public class DayOne
{
    public Tuple<int, int> PartOne(int[] oneData)
    {
        int? previousValue = null;
        var increaseCount = 0;
        var decreaseCount = 0;

        for (var i = 0; i < oneData.Count(); i++)
        {
            if (previousValue == null)
            {
                Console.WriteLine($"{oneData[i]} (N/A - no previous measurement)");
            }
            else
            {
                if (previousValue < oneData[i])
                {
                    increaseCount++;
                }
                else if (previousValue > oneData[i])
                {
                    decreaseCount++;
                }
            }

            previousValue = oneData[i];
        }

        return new Tuple<int, int>(increaseCount, decreaseCount);
    }

    public Tuple<int, int> PartTwo(int[] oneData)
    {
        int? previousValue = null;
        var increaseCount = 0;
        var decreaseCount = 0;

        for (var i = 0; i < oneData.Count() - 2; i++)
        {
            var sum = oneData[i] + oneData[i + 1] + oneData[i + 2];
            if (previousValue == null)
            {
                Console.WriteLine($"{sum} (N/A - no previous measurement)");
            }
            else
            {
                if (previousValue < sum)
                {
                    increaseCount++;
                }
                else if (previousValue > sum)
                {
                    decreaseCount++;
                }
            }

            previousValue = sum;
        }

        return new Tuple<int, int>(increaseCount, decreaseCount);
    }
}