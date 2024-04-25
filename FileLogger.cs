using System;
using System.IO;

public class FileLogger : ILogger
{
    private const string FilePath = "LogData.json";

    public void Log(string message)
    {
        using var streamWriter = File.AppendText(FilePath);
        streamWriter.WriteLine($"{DateTime.UtcNow}: {message}");
    }
}