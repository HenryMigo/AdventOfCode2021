using AdventOfCode2021.Days;
using AdventOfCode2021.Core;

var filePath = "/dev/AdventOfCode2022/AdventOfCode2021/Files/";

var dayFive = new DayFive();
var data = FileHelper.ReadFileToStringList($"{filePath}DayFiveExample.txt");
var commands = dayFive.ToModel(data);
dayFive.PopulateBoard(commands);

var result = dayFive.PartOne(commands);

Console.WriteLine($"Result: {result}");

Console.ReadLine();