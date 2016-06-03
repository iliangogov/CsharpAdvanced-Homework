using System;
namespace MaximalKsum
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());
            int[] num = new int[N];
            int sum = 0;
            for(int i=0;i< N;i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(num);
           
                for(int z=N-K;z< N;z++)
                {

                sum += num[z];    
                }
            
            Console.WriteLine(sum);
        }
    }
}
