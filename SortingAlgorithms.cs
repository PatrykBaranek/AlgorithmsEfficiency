namespace LabAlgorithms;
public static class SortingAlgorithms
{

    public static int[] InsertionSort(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            int key = arr[i];
            int j = i - 1;

            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j -= 1;
            }

            arr[j + 1] = key;
        }

        return arr;
    }

    public static int[] QuickSortClassical(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pi = Partition(arr, low, high);

            QuickSortClassical(arr, low, pi - 1);
            QuickSortClassical(arr, pi + 1, high);
        }

        return arr;
    }

    private static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];

        int i = (low - 1);

        for (int j = low; j <= high - 1; j++)
        {
            if (arr[j] < pivot)
            {
                i++;
                Swap(arr, i, j);
            }
        }

        Swap(arr, i + 1, high);
        return (i + 1);
    }

    private static void Swap(int[] arr, int i, int j)
    {
        (arr[i], arr[j]) = (arr[j], arr[i]);
    }


    public static int[] QuickSort(int[] arr)
    {
        Array.Sort(arr);

        return arr;
    }

}