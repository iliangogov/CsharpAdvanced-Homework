using System;
using System.Numerics;
namespace BinaryToDecimal
{
    class Program
    {
        static ulong BinaryToDecimal(string str)
        {
            ulong decNum = 0;
            ulong power = 1; //power 2^0 e edno
            for(int i=0;i<str.Length;i++)
            {
                decNum += (ulong.Parse(str[str.Length-1-i].ToString() )* (power)); //posledniq element ot stringa umnojen po 2na stepen i
                power *= 7;
            }
            return decNum;
        }
        static void Main()
        {
            string userInput = Console.ReadLine();
            Console.WriteLine(BinaryToDecimal(userInput));
        }
    }
}
