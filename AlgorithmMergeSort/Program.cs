using System;
using System.Collections.Generic;

class MergeSortAlgorithm
{
    static List<int> MergeSort(List<int> intList)
    {
        if (intList.Count <= 1)
        {
            return intList;
        }
        List<int> left = new List<int>();
        List<int> right = new List<int>();
        int middle = intList.Count / 2;
        for (int i = 0; i < middle; i++)
        {
            left.Add(intList[i]);
        }
        for (int i = middle; i < intList.Count; i++)
        {
            right.Add(intList[i]);
        }
        left = MergeSort(left);
        right = MergeSort(right);
        return Merge(left, right);
    }

    static List<int> Merge(List<int> left, List<int> right)
    {
        List<int> result = new List<int>();
        while (left.Count > 0 || right.Count > 0)
        {
            if (left.Count > 0 && right.Count > 0)
            {
                if (left[0] < right[0])
                {
                    AddAndRemove(left, result);
                }
                else
                {
                    AddAndRemove(right, result);
                }
            }
            else if (left.Count > 0)
            {
                AddAndRemove(left, result);
            }
            else
            {
                AddAndRemove(right, result);
            }
        }
        return result;
    }

    private static void AddAndRemove(List<int> removeFrom, List<int> addTo)
    {
        addTo.Add(removeFrom[0]);
        removeFrom.RemoveAt(0);
    }
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int index = 0; index < n; index++)
        {
            arr[index] = int.Parse(Console.ReadLine());
        }
        List<int> intList = new List<int>(arr);
        foreach (int i in MergeSort(intList))
        {
            Console.WriteLine(i);
        }
    }
}