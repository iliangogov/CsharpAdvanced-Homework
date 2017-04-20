using System;
using System.Collections.Generic;
using System.Linq;

namespace AllocateArray
{
    class Program
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            //var digitarr = new List<int>(count);
            int[] digitarr = new int[count];

            if (count != 0)
            {
                for (int i = 0; i < count; i++)
                {
                    digitarr[i] = i * 5;
                    Console.WriteLine(digitarr[i]);
                }

                Console.WriteLine(digitarr.Average());
                Console.WriteLine(digitarr.Max());
                Console.WriteLine(digitarr.Min());
                Console.WriteLine(digitarr.Sum());
            }

            //ExtensionMethods
            Console.WriteLine(digitarr.AverageValue());
            Console.WriteLine(digitarr.TotalSum());
        }
    }
}
