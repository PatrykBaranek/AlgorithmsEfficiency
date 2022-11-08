using LabAlgorithms.Algorithms;

namespace LabAlgorithms;
public static class SortingAlgorithms
{
    public static int[] InsertionSort(int[] arr)
    {
        return InsertionSortAlgorithm.Sort(arr);
    }

    public static int[] QuickSortClassical(int[] arr, int i, int j)
    {
        return QuickSortClassicalAlgorithm.Sort(arr, i, j);
    }

    public static int[] QuickSort(int[] arr)
    {
        Array.Sort(arr);

        return arr;
    }

    public static int[] MergeSort(int[] arr, int l, int r)
    {
        return MergeSortAlgorithm.Sort(arr, l, r);
    }
}