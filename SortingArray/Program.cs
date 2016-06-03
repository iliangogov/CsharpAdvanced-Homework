using System;
using System.Linq;
namespace SortingArray
{
    class Program
    {
        // GetMax
        public static int GetMax(int[] toSort,int StartAt,int StopAt)
        {
            int MaxNumberIndex = -1;
            int MaxNumber = int.MinValue;

            for (int curElement = StartAt;curElement <= StopAt;curElement++)
            {
                if (toSort[curElement] > MaxNumber)
                {
                    MaxNumberIndex = curElement;
                    MaxNumber = toSort[curElement];
                }
            }

            // return the index
            return MaxNumberIndex;
        }

        // Sort Descending - Sort Array Left to Right
        public static int[] SortDescending(int[] toSort)
        {
            // For each element
            for (int CurElement = 0; CurElement < toSort.Length;CurElement++)
            {
                var curMaxIndex = GetMax(toSort, CurElement, toSort.Length - 1);

                if (CurElement != curMaxIndex)
                {
                    toSort[CurElement] ^= toSort[curMaxIndex];
                    toSort[curMaxIndex] ^= toSort[CurElement];
                    toSort[CurElement] ^= toSort[curMaxIndex];
                }
            }

            return toSort;
        }

        // Sort Ascending - Sort Array Right to Left
        public static int[] SortAscending(int[] toSort)
        {
            //SortAscending
            for (int CurElement = toSort.Length - 1;CurElement >= 0;CurElement--)
            {
                var curMaxIndex = GetMax(toSort, 0,CurElement);

                if (CurElement != curMaxIndex)
                {
                    toSort[CurElement] ^= toSort[curMaxIndex];
                    toSort[curMaxIndex] ^= toSort[CurElement];
                    toSort[CurElement] ^= toSort[curMaxIndex];
                }
            }

            return toSort;
        }
        static void PrintArrWithSpaces(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == arr.Length - 1)
                {
                    Console.Write(arr[i]);
                }
                else
                {
                    Console.Write(arr[i] + " ");
                }
            }
            Console.WriteLine();
        }
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            int[] userNum = new int[size];
            userNum = Console.ReadLine().Trim(' ').Split(' ').Select(digit => int.Parse(digit)).ToArray();
            PrintArrWithSpaces(SortAscending(userNum));
        }
    }
}
