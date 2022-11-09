using System.Diagnostics;

namespace LabAlgorithms;
public static class Timer
{
    private static readonly Stopwatch _stopwatch = new Stopwatch();
    private static TimeSpan _sum = new();
    private static List<TimeSpan> _timeArr = new();

    public static void Start()
    {
        _stopwatch.Start();
    }

    public static void Stop()
    {
        _stopwatch.Stop();
        _sum += _stopwatch.Elapsed;
        _timeArr.Add(_stopwatch.Elapsed);
        _stopwatch.Reset();
    }

    public static void GetAvgTimeAndStandardDeviation(string algorithmName)
    {
        Console.WriteLine($"{algorithmName}: {AvgTime()} +/- {StandardDeviation()}");
    }

    private static double AvgTime()
    {
        return Math.Round(_sum.TotalMilliseconds / 10, 4);
    }

    private static double StandardDeviation()
    {
        var avgTime = AvgTime();
        var nominator = _timeArr.Sum(d => Math.Pow(d.TotalMilliseconds - avgTime, 2));


        return Math.Round(Math.Sqrt(nominator / _timeArr.Count), 4);
    }

}