using AdventOfCode2021.Days;
using AdventOfCode2021.Core;

var filePath = "/media/henrymigo/New Volume/dev/AdventOfCode2022/Files/";

var dayOne = new DayOne();
var dayOneData = FileHelper.ReadFileToIntArray($"{filePath}DayOne.txt");

var oneData = dayOneData as int[] ?? dayOneData.ToArray();

var dayOnePartOneResults = dayOne.PartOne(oneData);

Console.WriteLine("Day One - Part one:");
Console.WriteLine($"Increased: {dayOnePartOneResults.Item1}");
Console.WriteLine($"Decreased: {dayOnePartOneResults.Item2}");

var dayOnePartTwoResults = dayOne.PartTwo(oneData);

Console.WriteLine("Day One - Part two:");
Console.WriteLine($"Increased: {dayOnePartTwoResults.Item1}");
Console.WriteLine($"Decreased: {dayOnePartTwoResults.Item2}");

var dayTwo = new DayTwo();
var dayTwoData = FileHelper.ReadFileToStringList($"{filePath}DayTwo.txt");
var dayTwoItems = new List<DayTwoModel>();

foreach (var data in dayTwoData)
{
    var items = data.Split(' ');
    
    dayTwoItems.Add(new DayTwoModel(items[0], int.Parse(items[1])));
}

var dayTwoPartOneResult = dayTwo.PartOne(dayTwoItems);

Console.WriteLine("Day Two - Part one:");
Console.WriteLine($"{dayTwoPartOneResult}");

var dayTwoPartTwoResult = dayTwo.PartTwo(dayTwoItems);

Console.WriteLine("Day Two - Part two:");
Console.WriteLine($"{dayTwoPartTwoResult}");

Console.ReadLine();