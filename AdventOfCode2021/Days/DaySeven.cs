namespace AdventOfCode2021.Days;

public class DaySeven
{
    public void GetCheapestFuelCost(string data)
    {
        var positions = data.Split(',').Select(int.Parse).ToArray();

        var part1 = FindBottomOfCurve(CalculateConstantConsumption);
        var part2 = FindBottomOfCurve(CalculateIncreasingConsumption);
        
        Console.WriteLine($"Part 1: {part1}");
        Console.WriteLine($"Part 2: {part2}");

        int CalculateConstantConsumption(int position)
        {
            return positions.Sum(t => Math.Abs(t - position));
        }

        int CalculateIncreasingConsumption(int position)
        {
            var sum = 0;

            foreach (var t in positions)
            {
                for (var j = 1; j <= Math.Abs(t - position); j++)
                {
                    sum += j;
                }
            }

            return sum;
        }

        int FindBottomOfCurve(Func<int, int> func)
        {
            var position = 0;
            var limit = 2000;

            var c1 = 0;

            for (var i = 100; i > 0; i /= 10)
            {
                for (var p = position; p < limit; p += i)
                {
                    c1 = func(p);
                    var c2 = func(p + 1);

                    if (c1 > c2)
                    {
                        position = p;
                    }
                    else
                    {
                        limit = p;
                        break;
                    }
                }
            }

            return c1;
        }
    }
}