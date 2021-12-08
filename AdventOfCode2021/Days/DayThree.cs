namespace AdventOfCode2021.Days;

public class DayThree
{
    public int PartOne(IEnumerable<string> threeData)
    {
        var mostCommonResult = string.Empty;
        var leastCommonResult = string.Empty;

        var dayThreeData = threeData as string[] ?? threeData.ToArray();

        for (var i = 0; i < dayThreeData.ToArray()[i].Length; i++)
        {
            var ones = 0;
            var zeros = 0;

            for (var y = 0; y < dayThreeData.ToArray().Length; y++)
            {
                var value = dayThreeData[y];

                if (int.Parse(value[i].ToString()) == 1)
                {
                    ones++;
                }
                else
                {
                    zeros++;
                }
            }

            if (ones > zeros)
            {
                mostCommonResult += 1;
                leastCommonResult += 0;
            }

            if (zeros > ones)
            {
                mostCommonResult += 0;
                leastCommonResult += 1;
            }
        }

        var mostAsBit = Convert.ToInt32(mostCommonResult, 2);
        var leastAsBit = Convert.ToInt32(leastCommonResult, 2);

        return mostAsBit * leastAsBit;
    }

    public int PartTwo(IEnumerable<string> threeData)
    {
        var mostCommonResult = string.Empty;
        var leastCommonResult = string.Empty;

        var dayThreeDataMost = threeData as string[] ?? threeData.ToArray();
        var dayThreeDataLeast = threeData as string[] ?? threeData.ToArray();
        var length = dayThreeDataMost.ToArray()[0].Length;

        for (var i = 0; i < length; i++)
        {
            var ones = 0;
            var zeros = 0;

            CalculateMostAndLeastCommon(dayThreeDataMost, i, ref ones, ref zeros);

            if (dayThreeDataMost.Length == 1)
            {
                break;
            }

            if (ones > zeros)
            {
                RemoveThoseNotInCriteria(ref dayThreeDataMost, i, '1');
            }

            if (zeros > ones)
            {
                RemoveThoseNotInCriteria(ref dayThreeDataMost, i, '0');
            }

            if (zeros == ones)
            {
                RemoveThoseNotInCriteria(ref dayThreeDataMost, i, '1');
            }

            length = dayThreeDataMost.ToArray()[0].Length;
        }

        length = dayThreeDataLeast.ToArray()[0].Length;
        for (var i = 0; i < length; i++)
        {
            var ones = 0;
            var zeros = 0;

            CalculateMostAndLeastCommon(dayThreeDataLeast, i, ref ones, ref zeros);

            if (dayThreeDataLeast.Length == 1)
            {
                break;
            }

            if (ones > zeros)
            {
                RemoveThoseNotInCriteria(ref dayThreeDataLeast, i, '0');
            }

            if (zeros > ones)
            {
                RemoveThoseNotInCriteria(ref dayThreeDataLeast, i, '1');
            }

            if (zeros == ones)
            {
                RemoveThoseNotInCriteria(ref dayThreeDataLeast, i, '0');
            }

            length = dayThreeDataLeast.ToArray()[0].Length;
        }

        mostCommonResult = dayThreeDataMost.Aggregate(mostCommonResult, (current, most) => current + most.ToString());
        leastCommonResult =
            dayThreeDataLeast.Aggregate(leastCommonResult, (current, least) => current + least.ToString());

        var mostAsBit = Convert.ToInt32(mostCommonResult, 2);
        var leastAsBit = Convert.ToInt32(leastCommonResult, 2);

        return mostAsBit * leastAsBit;
    }

    private void CalculateMostAndLeastCommon(IReadOnlyList<string> threeData, int i, ref int ones, ref int zeros)
    {
        for (var y = 0; y < threeData.ToArray().Length; y++)
        {
            var value = threeData[y];

            if (int.Parse(value[i].ToString()) == 1)
            {
                ones++;
            }
            else
            {
                zeros++;
            }
        }
    }

    private void RemoveThoseNotInCriteria(ref string[] threeData, int i, char criteria)
    {
        threeData = threeData.Where(x => x[i] == criteria).ToArray();
    }
}