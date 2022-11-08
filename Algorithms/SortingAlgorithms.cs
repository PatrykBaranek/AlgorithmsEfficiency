namespace LabAlgorithms.Algorithms;
public static class SortingAlgorithms
{
    public static int[] InsertionSort(int[] arr) => InsertionSortAlgorithm.Sort(arr);
    public static int[] QuickSortClassical(int[] arr) => QuickSortClassicalAlgorithm.Sort(arr, arr.Min(), arr.Max());
    public static int[] MergeSort(int[] arr) => MergeSortAlgorithm.Sort(arr, 0, arr.Length - 1);

    public static int[] QuickSort(int[] arr)
    {
        Array.Sort(arr);

        return arr;
    }
}