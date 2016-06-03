using System;

class QuickSortAlgorithm
{
    static void SwapElements(string[] arr, int first, int second)
    {
        string temp = arr[first];
        arr[first] = arr[second];
        arr[second] = temp;
    }

    static int Partition(string[] arr, int left, int right, int pivotIndex)
    {
        string pivot = arr[pivotIndex];
        SwapElements(arr, pivotIndex, right);

        int storeIndex = left;
        for (int i = left; i < right; i++)
        {
            if (string.Compare(arr[i], pivot) <= 0)
            {
                SwapElements(arr, storeIndex, i);
                storeIndex++;
            }
        }
        SwapElements(arr, storeIndex, right);
        return storeIndex;
    }

    static void QuickSort(string[] arr, int left, int right)
    {
        if (left >= right)
        {
            return;
        }
        int pivotIndex = left + (right + 1 - left) / 2;
        int pivotNewIndex = Partition(arr, left, right, pivotIndex);
        QuickSort(arr, left, pivotNewIndex - 1);
        QuickSort(arr, pivotNewIndex + 1, right);
    }

    static void Main()
    {
        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());
        string[] arr = new string[n];
        for (int index = 0; index < n; index++)
        {
            Console.Write("Enter element {0}: ", index);
            arr[index] = Console.ReadLine();
        }
        QuickSort(arr, 0, arr.Length - 1);
        foreach (string str in arr)
        {
            Console.WriteLine(str);
        }
    }
}