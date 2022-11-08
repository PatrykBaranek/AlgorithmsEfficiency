using System.Diagnostics;

namespace LabAlgorithms;
public static class Timer
{
    private static readonly Stopwatch _stopwatch = new Stopwatch();

    public static void Start()
    {
        _stopwatch.Start();
    }

    public static void Stop(string algorithmName)
    {
        _stopwatch.Stop();
        Console.WriteLine($"{algorithmName} {_stopwatch.ElapsedMilliseconds}");
        _stopwatch.Reset();
    }

}