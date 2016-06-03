
using System;

class BinarySearch
{
    static void Search(int[] arr, int start, int end, int element)
    {
        if (end <= start)
        {
            Console.WriteLine("Not Found!");
            return;
        }
        else
        {
            int middle = start + (end - start) / 2;
            if (element < arr[middle])
            {
                Search(arr, start, middle - 1, element);
            }
            else if (element > arr[middle])
            {
                Search(arr, middle + 1, end, element);
            }
            else
            {
                Console.WriteLine("The index of {0} is {1}", element, middle);
                return;
            }
        }
    }
}