using AdventOfCode2021.Days;
using AdventOfCode2021.Core;

var filePath = "/dev/AdventOfCode2022/Files/";

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