using System;
using System.Globalization;
namespace DateDiferance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input : 
            // Line 1 - Date 1
            // Line 2 - Date 2
            var Date1 = DateTime
                .ParseExact(
                    Console.ReadLine(),
                    "d.MM.yyyy",
                    CultureInfo.InvariantCulture);

            var Date2 = DateTime
                .ParseExact(
                    Console.ReadLine(),
                    "d.MM.yyyy",
                    CultureInfo.InvariantCulture);


            TimeSpan TimeDifference = Date2 - Date1;

            Console.WriteLine(TimeDifference.Days);
        }
    }
}
