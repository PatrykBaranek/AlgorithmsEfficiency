using LabAlgorithms.Algorithms;

namespace LabAlgorithms.ReportFactory;
public class QuickReport : IReportFactory
{
    public void StartTimer()
    {
        Timer.Start();
    }

    public void StopTimer()
    {
        Timer.Stop(this.GetType().Name);
    }

    public void GenerateReport(int[] arr)
    {
        StartTimer();
        SortingAlgorithms.QuickSort(arr);
        StopTimer();
    }
}