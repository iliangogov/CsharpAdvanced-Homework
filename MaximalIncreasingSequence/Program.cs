using System;
namespace MaximalIncreasingSequence
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] nums = new int[N];
            int bestlength = 0;
            int counter = 0;
            int previousnum = 0;
            for (int i = 0; i < N; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
                if (i == 0) { previousnum = nums[i]; }

                if (nums[i] > previousnum)
                {
                    counter++;

                }
                else
                {
                    counter = 1;
                }
                if (counter > bestlength)
                {
                    bestlength = counter;
                }
                previousnum = nums[i];
            }
            Console.WriteLine(bestlength);
        }
    }
}
