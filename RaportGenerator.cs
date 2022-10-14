using System.Diagnostics;

namespace LabAlgorithms;
public static class RaportGenerator
{
    private static Stopwatch _stopwatch = new Stopwatch();

    public static void GenerateRaport(int[] arr)
    {
        _stopwatch.Start();

        SortingAlgorithms.InsertionSort(arr);
        _stopwatch.Stop();
    }
}