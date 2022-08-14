using System.Text.RegularExpressions;

namespace AdventOfCode2021.Days
{
    public class DayFive
    {
        private readonly string filePath = "/dev/AdventOfCode2022/AdventOfCode2021/Files/DayFive.txt";

        public int GetCountOfOverlaps(bool includeDiagonals) => File.ReadAllLines(filePath).SelectMany(input =>
        {
            var range = input.Split(" -> ");

            var (x1, y1) = range.First().Split(',').Select(int.Parse).ToArray() switch { var i => (i.First(), i.Last()) };
            var (x2, y2) = range.Last().Split(',').Select(int.Parse).ToArray() switch { var i => (i.First(), i.Last()) };

            var minX = Math.Min(x1, x2);
            var maxX = Math.Max(x1, x2) + 1;

            if (x1 != x2 && y1 != y2)
            {
                if (!includeDiagonals) return new List<(int, int)>();

                //determine direction of x and y
                var yPos = y1 < y2;
                var xPos = x1 < x2;

                return Enumerable.Range(x1, maxX - minX).Select(_ => (xPos ? x1++ : x1--, yPos ? y1++ : y1--));
            }

            var isHorizontal = x1 == x2;

            var minY = Math.Min(y1, y2);
            var maxY = Math.Max(y1, y2) + 1;

            return Enumerable.Range(isHorizontal ? minY : minX, isHorizontal ? maxY - minY : maxX - minX)
                .Select(i => isHorizontal ? (minX, i) : (i, minY));

        }).GroupBy(range => range).Count(p => p.Count() >= 2);

    }
}
