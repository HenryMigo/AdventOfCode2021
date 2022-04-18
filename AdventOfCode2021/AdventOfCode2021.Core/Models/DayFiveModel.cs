namespace AdventOfCode2021.Core.Models
{
    public class DayFiveModel
    {
        public int StartX { get; set; }
        public int StartY { get; set; }
        public int TargetX { get; set; }
        public int TargetY { get; set; }

        public DayFiveModel(int startX, int startY, int targetX, int targetY)
        {
            StartX = startX;
            StartY = startY;
            TargetX = targetX;
            TargetY = targetY;
        }
    }
}
