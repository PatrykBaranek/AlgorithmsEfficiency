using LabAlgorithms.Algorithms;

namespace LabAlgorithms.ReportFactory;
public class MergeReport : IReportFactory
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
            var arr1 = (int[])arr.Clone();
            StartTimer();
            SortingAlgorithms.MergeSort(arr1);
            StopTimer();
        }

        Timer.GetAvgTimeAndStandardDeviation(this.GetType().Name.Replace("Report", "Sort"));
    }
}