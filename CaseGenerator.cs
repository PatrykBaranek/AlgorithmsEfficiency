using LabAlgorithms.ReportFactory;

namespace LabAlgorithms;
public class CaseGenerator
{
    private readonly InsertionReport _insertionFactory;
    private readonly MergeReport _mergeFactory;
    private readonly QuickClassicalReport _quickClassicalFactory;
    private readonly QuickReport _quickFactory;
    public CaseGenerator()
    {
        _insertionFactory = new InsertionReport();
        _mergeFactory = new MergeReport();
        _quickClassicalFactory = new QuickClassicalReport();
        _quickFactory = new QuickReport();
    }

    public void Start(int[] arr, int caseNumber, GeneratorsTypes generatorsTypes)
    {
        Console.WriteLine($"Case {caseNumber}: array size (n = {arr.Length}), {generatorsTypes}");

        _insertionFactory.GenerateReport(arr);
        _mergeFactory.GenerateReport(arr);
        _quickClassicalFactory.GenerateReport(arr);
        _quickFactory.GenerateReport(arr);

        Console.WriteLine();
    }
}