namespace AdventOfCode2021.Core;

public static class FileHelper
{
    public static IEnumerable<int> ReadFileToIntArray(string fileLocation)
    {
        var text = File.ReadAllLines(fileLocation);

        return text.Select(int.Parse).ToList();
    }

    public static IEnumerable<string> ReadFileToStringList(string fileLocation)
    {
        var text = File.ReadAllLines(fileLocation);

        return text.ToList();
    }
}