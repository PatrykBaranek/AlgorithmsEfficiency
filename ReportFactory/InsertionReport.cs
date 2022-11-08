using LabAlgorithms.Algorithms;

namespace LabAlgorithms.ReportFactory;
public class InsertionReport : IReportFactory
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
        SortingAlgorithms.InsertionSort(arr);
        StopTimer();
    }
}