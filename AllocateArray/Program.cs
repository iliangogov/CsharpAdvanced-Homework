using System;
namespace AllocateArray
{
    class Program
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            int[] digitarr= new int[count];
           
            for(int i=0;i<digitarr.Length;i++)
            {
              digitarr[i] = i * 5;
                Console.WriteLine(digitarr[i]);
            }
           
        }
    }
}
