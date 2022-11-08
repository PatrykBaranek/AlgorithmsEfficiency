using LabAlgorithms;
using LabAlgorithms.ReportFactory;

var smallArray = Generators.GenerateRandom(100, 1, 11);
var midArray = Generators.GenerateRandom(1000, 1, 1000);
var largeArray = Generators.GenerateRandom(10000, 1, 2000);


IReportFactory reportFactory = new InsertionReport();

reportFactory.GenerateReport(smallArray);
reportFactory.GenerateReport(midArray);
reportFactory.GenerateReport(largeArray);

reportFactory = new MergeReport();

reportFactory.GenerateReport(smallArray);
reportFactory.GenerateReport(midArray);
reportFactory.GenerateReport(largeArray);

reportFactory = new QuickClassicalReport();

reportFactory.GenerateReport(smallArray);
reportFactory.GenerateReport(midArray);
reportFactory.GenerateReport(largeArray);

reportFactory = new QuickReport();

reportFactory.GenerateReport(smallArray);
reportFactory.GenerateReport(midArray);
reportFactory.GenerateReport(largeArray);