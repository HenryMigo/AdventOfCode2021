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
                if (coordinates.StartX > MaxX) MaxX = coordinates.StartX;
                if (coordinates.StartY > MaxY) MaxY = coordinates.StartY;
                if (coordinates.TargetX > MaxX) MaxX = coordinates.TargetX;
                if (coordinates.TargetY > MaxY) MaxY = coordinates.TargetY;
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
                if (coordinates.StartX == coordinates.TargetX)
                {
                    CheckVertical(coordinates);
                }
                else if (coordinates.StartY == coordinates.TargetY)
                {
                    CheckHorizontal(coordinates);
                }
            }

            return _vents.Sum(vent => vent.Count(x => x > 1));
        }

        private void CheckHorizontal(DayFiveModel coordinates)
        {
            if (coordinates.StartX > coordinates.TargetX)
            {
                for (var x = coordinates.StartX; x >= coordinates.TargetX; x--)
                {
                    _vents[coordinates.StartY][x] += 1;
                }
            }
            else
            {
                for (var x = coordinates.StartX; x <= coordinates.TargetX; x++)
                {
                    _vents[coordinates.StartY][x] += 1;
                }
            }
        }

        private void CheckVertical(DayFiveModel coordinates)
        {
            if (coordinates.StartY > coordinates.TargetY)
            {
                for (var y = coordinates.StartY; y >= coordinates.TargetY; y--)
                {
                    _vents[y][coordinates.StartX] += 1;
                }
            }
            else
            {
                for (var y = coordinates.StartY; y <= coordinates.TargetY; y++)
                {
                    _vents[y][coordinates.StartX] += 1;
                }
            }
        }
    }
}
