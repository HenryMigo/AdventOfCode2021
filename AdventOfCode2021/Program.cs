using AdventOfCode2021.Days;
using AdventOfCode2021.Core;

var filePath = "/dev/AdventOfCode2022/Files/";

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
var dayTwoItems = dayTwo.ConvertToModels(dayTwoData);
var dayTwoPartOneResult = dayTwo.PartOne(dayTwoItems);

Console.WriteLine("Day Two - Part one:");
Console.WriteLine($"{dayTwoPartOneResult}");

var dayTwoPartTwoResult = dayTwo.PartTwo(dayTwoItems);

Console.WriteLine("Day Two - Part two:");
Console.WriteLine($"{dayTwoPartTwoResult}");

var dayThree = new DayThree();
var dayThreeData = FileHelper.ReadFileToStringList($"{filePath}DayThree.txt");
var dayThreePartOneResult = dayThree.PartOne(dayThreeData);

Console.WriteLine("Day Three - Part one:");
Console.WriteLine($"{dayThreePartOneResult}");

var dayThreePartTwoResult = dayThree.PartTwo(dayThreeData);

Console.WriteLine("Day Three - Part two:");
Console.WriteLine($"{dayThreePartTwoResult}");

var dayFour = new DayFour();
var dayFourData = FileHelper.ReadFileToBingo($"{filePath}DayFour.txt");
var dayFourPartOneResult = dayFour.PartOne(dayFourData);

Console.WriteLine("Day Four - Part one:");
Console.WriteLine($"{dayFourPartOneResult}");

var dayFourPartTwoResult = dayFour.PartTwo(dayFourData);

Console.WriteLine("Day Four - Part two:");
Console.WriteLine($"{dayFourPartTwoResult}");

Console.ReadLine();