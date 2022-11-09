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
        Timer.Stop();
    }

    public void GenerateReport(int[] arr)
    {
        for (int i = 0; i < 10; i++)
        {
            StartTimer();
            SortingAlgorithms.InsertionSort(arr);
            StopTimer();
        }

        Timer.GetAvgTimeAndStandardDeviation(this.GetType().Name.Replace("Report", "Sort"));
    }
}