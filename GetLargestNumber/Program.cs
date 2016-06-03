using System;
namespace GetLargestNumber
{
    class Program
    {
        static void GetMax()
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);
            int a = input[0];
            int b = input[1];
            int c = input[2];
            int max;
            if(a>b)
            {
                max = a;
                if(a<c)
                {
                    max = c;
                }
            }
            else//b>a
            {
                max = b;
                if(c>b)
                {
                    max = c;
                }
            }
            Console.WriteLine(max);
        }
        static void Main()
        {
            GetMax();
        }
    }
}
