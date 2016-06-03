using System;
using System.Text;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();
            StringBuilder reversed = new StringBuilder();
            for(int i=userInput.Length-1;i>=0;i--)
            {
                reversed.Append(userInput[i]);
            }
            Console.WriteLine(reversed);
        }
    }
}
