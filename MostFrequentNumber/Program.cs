using System;
namespace MostFrequentNumber
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] nums = new int[N];
      
            int counter = 0;
            int repeatNum = 0;
            int bestcounter = 0;
            for (int i = 0; i < N; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(nums);
           
            for(int j=1;j< N;j++)
            {
                if (nums[j] != nums[j-1])
                {
                    counter = 1;
                }
                if(nums[j]==nums[j-1])
                {
                    counter++;
                   
                }


                if (counter > bestcounter)
                {
                    bestcounter = counter;
                    repeatNum = nums[j];
                }
            }
            Console.WriteLine("{0} ({1} times)",repeatNum,bestcounter);
        }
    }
}
