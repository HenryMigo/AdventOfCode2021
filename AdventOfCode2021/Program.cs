using AdventOfCode2021;
using AdventOfCode2021.Core;

var filePath = "/media/henrymigo/New Volume/dev/AdventOfCode2022/Files/";

var dayOne = new DayOne();
var dayOneData = FileHelper.ReadFile($"{filePath}DayOne.txt");

var oneData = dayOneData as int[] ?? dayOneData.ToArray();

int? previousValue = null;
int increaseCount = 0;
int decreaseCount = 0;

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

Console.WriteLine($"Increased: {increaseCount}");
Console.WriteLine($"Decreased: {decreaseCount}");

Console.ReadLine();