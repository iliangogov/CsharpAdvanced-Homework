using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargerThanNeighbours
{
    class Program
    {
        static void largerThanNneighbours()
        {
            int N = int.Parse(Console.ReadLine());
            int[] array = new int[N];
            array = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);
            int counter = 0;
            for (int i = 1; i < N - 1; i++)
            {
                if (array[i] > array[i - 1] && array[i] > array[i + 1])
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
        static void Main(string[] args)
        {
            largerThanNneighbours();
        }
    }
}
