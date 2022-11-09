using LabAlgorithms;

// small arrays

var smallRandomArray = Generators.GenerateRandom(10, 1, 10);
var smallSortedArray = Generators.GenerateSorted(10, 1, 10);
var smallReverseArray = Generators.GenerateReversed(10, 1, 10);

// mid arrays

var midRandomArray = Generators.GenerateRandom(1000, 1, 1000);
var midSortedArray = Generators.GenerateSorted(1000, 1, 1000);
var midReverseArray = Generators.GenerateReversed(1000, 1, 1000);

// large arrays

var largeRandomArray = Generators.GenerateRandom(10000, 1, 10000);
var largeSortedArray = Generators.GenerateSorted(10000, 1, 10000);
var largeReversArray = Generators.GenerateReversed(10000, 1, 10000);


// Few unique array

var fewUniqueArray = Generators.GenerateRandom(100, 1, 10);

var caseGenerator = new CaseGenerator();

// 1. small try random

caseGenerator.Start(smallRandomArray, 1, GeneratorsTypes.Random);

// 2. small try sorted

caseGenerator.Start(smallSortedArray, 2, GeneratorsTypes.Sorted);

// 3. small try reverse 

caseGenerator.Start(smallReverseArray, 3, GeneratorsTypes.Reverse);

// 4. small try few unique

caseGenerator.Start(fewUniqueArray, 4, GeneratorsTypes.FewUnique);

// 5. mid try random

caseGenerator.Start(midRandomArray, 5, GeneratorsTypes.Random);

// 6. mid try sorted

caseGenerator.Start(midSortedArray, 6, GeneratorsTypes.Sorted);

// 7. mid try reverse

caseGenerator.Start(midReverseArray, 7, GeneratorsTypes.Reverse);
// 8. mid try few unique

caseGenerator.Start(fewUniqueArray, 8, GeneratorsTypes.FewUnique);

// 9. large try random

caseGenerator.Start(largeRandomArray, 9, GeneratorsTypes.Random);

// 10. large try sorted

caseGenerator.Start(largeSortedArray, 10, GeneratorsTypes.Sorted);

// 11. large try reverse

caseGenerator.Start(largeReversArray, 11, GeneratorsTypes.Reverse);

// 12. large try few unique

caseGenerator.Start(fewUniqueArray, 12, GeneratorsTypes.FewUnique);
