using System;
using System.Numerics;
namespace DecimalToHexadecimal
{
    class Program
    {
        static string DecimalToHexadecimal(BigInteger DecNumber)
        {
            // variables
            string HexNumber = "";
            string HexKey = "0123456789ABCDEF";

            int tobase = 16;

            while (DecNumber > 0)
            {
                // Step 1: Remainders build the Hex number
                // Right To Left
                HexNumber = HexKey[(int)(DecNumber % tobase)]
                          + HexNumber;

                // Step 2: Divide the Dec Number by toBase
                DecNumber /= tobase;
            }
            return HexNumber;
        }
        static void Main()
        {
            BigInteger userInput =BigInteger.Parse( Console.ReadLine());
            Console.WriteLine(DecimalToHexadecimal(userInput));
        }
       
    }
}
