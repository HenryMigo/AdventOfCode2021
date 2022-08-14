using AdventOfCode2021.Days;

var daySeven = new DaySeven();
const string testData = "16,1,2,0,4,2,7,1,2,14";

var data = File.ReadLines(@"/dev/AdventOfCode2021/AdventOfCode2021/Files/DaySeven.txt").ToArray();

daySeven.GetCheapestFuelCost(data[0]);

Console.ReadLine();
