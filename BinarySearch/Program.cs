using System;
namespace BinarySearch
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] arr = new int[N];
            for(int i=0;i< N;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(arr);
            int X = int.Parse(Console.ReadLine());
            bool match = false;
            for(int j=0;j< N;j++)
            {
                if(arr[j]==X)
                {
                    Console.WriteLine(j);
                    match = true;
                    break;
                }

            }
            if(match==false)
            {
                Console.WriteLine(-1);
            }
        }
    }
}
