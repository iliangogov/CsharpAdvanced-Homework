using System;
namespace FirstLargerThanNeighbours
{
    class Program
    {
        static int firstIndex(int[]array)
        {
       
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i] > array[i - 1] && array[i] > array[i + 1])
                {
                    return i;
                }
                    
            }
            return -1;
        }
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] array = new int[N];
            array = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);
           Console.WriteLine( firstIndex(array));
        }
    }
}
