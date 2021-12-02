using AdventOfCode2021;
using AdventOfCode2021.Core;

var filePath = "/media/henrymigo/New Volume/dev/AdventOfCode2022/Files/";

var dayOne = new DayOne();
var dayOneData = FileHelper.ReadFile($"{filePath}DayOne.txt");

var oneData = dayOneData as int[] ?? dayOneData.ToArray();

var dayOnePartOneResults = dayOne.PartOne(oneData);

Console.WriteLine("Day One - Part one:");
Console.WriteLine($"Increased: {dayOnePartOneResults.Item1}");
Console.WriteLine($"Decreased: {dayOnePartOneResults.Item2}");

var dayOnePartTwoResults = dayOne.PartTwo(oneData);

Console.WriteLine("Day One - Part two:");
Console.WriteLine($"Increased: {dayOnePartTwoResults.Item1}");
Console.WriteLine($"Decreased: {dayOnePartTwoResults.Item2}");

Console.ReadLine();