using System;

namespace FormatNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var toPrint = int.Parse(Console.ReadLine());

            Console.WriteLine("{0, 15:D}", toPrint);
            Console.WriteLine("{0, 15:X}", toPrint);
            Console.WriteLine("{0, 15:P}", toPrint);
            Console.WriteLine("{0, 15:E}", toPrint);
        }
    }
}
