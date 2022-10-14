using LabAlgorithms;
using System.Diagnostics;

var stopwatch = new Stopwatch();

var smallArray = Generators.GenerateRandom(100,1,11);
var midArray = Generators.GenerateRandom(1000, 1, 1000);
var largeArray = Generators.GenerateRandom(100000,1,20000);


SortingAlgorithms.InsertionSort(smallArray);
SortingAlgorithms.QuickSortClassical(smallArray, 0, 9);
SortingAlgorithms.QuickSort(midArray);

