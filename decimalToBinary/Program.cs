using System;
namespace decimalToBinary
{
    class Program
    {
        static string decimalToBinary(ulong number)
        {
            string str = "";
            while(number>0)
            {
                str= (number % 2)+str;
                number /= 2;
            }
            return str;
        }
        static void Main()
        {
            ulong userInput = ulong.Parse(Console.ReadLine());
            string binary = decimalToBinary(userInput);
            foreach(char digit in binary)
            {
                Console.Write(digit); //ako iskame space!! ina4e Console.WriteLine(binary);
            }
            Console.WriteLine();
        }
    }
}
