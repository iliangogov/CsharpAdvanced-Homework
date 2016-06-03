using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareArrays
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int N = int.Parse(Console.ReadLine());
            int[] A = new int[N];
            int[] B = new int[N];
            bool equalElements = true;
            for (int i=0;i<N;i++)
            {
                A[i] = int.Parse(Console.ReadLine());
            }
            for(int j=0;j< N;j++)
            {
                B[j] = int.Parse(Console.ReadLine());
            }
            for(int z=0;z< N;z++)
            {
                if (A[z] != B[z])
                {
                    equalElements = false;

                }
            }
            Console.WriteLine(equalElements? "Equal": "Not equal");
        }
    }
}
