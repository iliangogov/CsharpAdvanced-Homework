using System;
namespace SelectionSort
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] nums = new int[N];
            for (int z = 0; z < N; z++)
            {
                nums[z] = int.Parse(Console.ReadLine());
            }
            int min = int.MaxValue;
            int minIndex = 0;
            int temp = 0;

            for (int i = 0; i < N; i++)
            {
                for (int j = i; j < N; j++)
                {
                    if (nums[j] < min)
                    {
                        min = nums[j];
                        minIndex = j;
                    }
                }
                temp = nums[i];
                nums[i] = min;
                nums[minIndex] = temp;
                min = int.MaxValue;
            }

            for (int y = 0; y < N; y++)
            {
                Console.WriteLine(nums[y]);
            }
        }
    }
}
