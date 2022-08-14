using MoreLinq;

namespace AdventOfCode2021.Days;

public class DaySix
{
    private class LanternFish
    {
        private int InternalTimer { get; set; }
        
        public LanternFish(int internalTimer)
        {
            InternalTimer = internalTimer;
        }

        public void DecreaseInternalTimer(int amount)
        {
            InternalTimer -= amount;
        }

        public void SetInternalTimer(int amount)
        {
            InternalTimer = amount;
        }

        public int GetInternalTimer()
        {
            return InternalTimer;
        }

        public int Day { get; set; }
        public int Total { get; set; }
    }

    private List<LanternFish> _lanternFishes;

    public int GetTotalAmount(int days)
    {
        _lanternFishes = new List<LanternFish>();
        
        var fileInput = File.ReadAllLines(@"/dev/AdventOfCode2022/AdventOfCode2021/Files/DaySix.txt");
        var inputSplit = fileInput[0].Split(',');

        foreach (var input in inputSplit)
        {
            _lanternFishes.Add(new LanternFish(int.Parse(input)));
        }

        var tempStore = new List<LanternFish>(_lanternFishes);
        
        for (var i = 0; i < days; i++)
        {
            foreach (var lanternFishes in tempStore.Batch(1000))
            {
                var zeroTimers = lanternFishes.Where(x => x.GetInternalTimer() == 0);
                var nonZeroTimers = lanternFishes.Where(x => x.GetInternalTimer() != 0);
                
                foreach (var zeroTimer in zeroTimers)
                {
                    zeroTimer.SetInternalTimer(6);
                    _lanternFishes.Add(new LanternFish(8));
                }

                foreach (var nonZeroTimer in nonZeroTimers)
                {
                    nonZeroTimer.DecreaseInternalTimer(1);
                }
            }

            tempStore = new List<LanternFish>(_lanternFishes);
            
            Console.WriteLine($"Day {i}");
        }

        return _lanternFishes.Count;
    }
}