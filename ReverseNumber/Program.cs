using System;
namespace ReverseNumber
{
    class Program
    {
        static string ReversedNumber(string num)
        {
            string reversed ="";
            for(int i=0;i<num.Length;i++)
            {
                reversed+= num[num.Length - 1 - i].ToString(); 
            }
            return reversed;
        }
        static void Main()
        {
            string num = Console.ReadLine();
           Console.WriteLine(ReversedNumber(num));
        }
    }
}
