namespace AdventOfCode2021.Core;

public static class FileHelper
{
    public static IEnumerable<int> ReadFile(string fileLocation)
    {
        var text = File.ReadAllLines(fileLocation);

        return text.Select(int.Parse).ToList();
    }
}