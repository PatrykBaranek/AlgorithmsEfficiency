namespace LabAlgorithms.ReportFactory;
public interface IReportFactory
{
    void StartTimer();
    void StopTimer();
    void GenerateReport(int[] arr);
}