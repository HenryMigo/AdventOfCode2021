using AdventOfCode2021.Core.Models;

namespace AdventOfCode2021.Days
{
    public class DayFive
    {
        private List<List<int>> _vents = new List<List<int>>();
        private int MaxX;
        private int MaxY;

        public List<DayFiveModel> ToModel(IEnumerable<string> inputs)
        {
            var list = new List<DayFiveModel>();

            foreach (var input in inputs)
            {
                var split = input.Split(new[] { "->" }, StringSplitOptions.None).Where(x => x.Trim() != string.Empty).ToList();
                var initialPoint = split[0].Trim().Split(',').Select(int.Parse).ToList();
                var targetPoint = split[1].Trim().Split(',').Select(int.Parse).ToList();

                list.Add(new DayFiveModel(initialPoint[0], initialPoint[1], targetPoint[0], targetPoint[1]));
            }

            return list;
        }

        public void PopulateBoard(List<DayFiveModel> data)
        {
            foreach (var coordinates in data)
            {
                if (coordinates.X1 > MaxX) MaxX = coordinates.X1;
                if (coordinates.Y1 > MaxY) MaxY = coordinates.Y1;
                if (coordinates.X2 > MaxX) MaxX = coordinates.X2;
                if (coordinates.Y2 > MaxY) MaxY = coordinates.Y2;
            }

            for (var y = 0; y <= MaxY; y++)
            {
                var xList = new List<int>();
                for (var x = 0; x <= MaxX; x++)
                {
                    xList.Add(0);
                }

                _vents.Add(xList);
            }
        }

        public int PartOne(List<DayFiveModel> data)
        {
            foreach (var coordinates in data)
            {
                if (coordinates.X1 == coordinates.X2)
                {
                    CheckVertical(coordinates);
                }
                else if (coordinates.Y1 == coordinates.Y2)
                {
                    CheckHorizontal(coordinates);
                }
            }

            var result = 0;

            foreach (var vent in _vents)
            {
                foreach (var coordinate in vent)
                {
                    Console.Write(coordinate);
                }

                result += vent.Count(x => x > 1);
                Console.WriteLine();
            }

            return result;
        }

        private void CheckHorizontal(DayFiveModel coordinates)
        {
            if (coordinates.X1 > coordinates.X2)
            {
                for (var x = coordinates.X1; x > coordinates.X2; x--)
                {
                    _vents[x][coordinates.Y1] += 1;
                }
            }
            else
            {
                for (var x = coordinates.X1; x < coordinates.X2; x++)
                {
                    _vents[x][coordinates.Y1] += 1;
                }
            }
        }

        private void CheckVertical(DayFiveModel coordinates)
        {
            if (coordinates.Y1 > coordinates.Y2)
            {
                for (var y = coordinates.Y1; y > coordinates.Y2; y--)
                {
                    _vents[coordinates.X1][y] += 1;
                }
            }
            else
            {
                for (var y = coordinates.Y1; y < coordinates.Y2; y++)
                {
                    _vents[coordinates.X1][y] += 1;
                }
            }
        }
    }
}
