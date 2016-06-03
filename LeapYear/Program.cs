using System;
using System.Globalization;
namespace LeapYear
{
    class Program
    {
        static void Main()
        {
           
            int Year = int.Parse(Console.ReadLine());
            bool isLeap = false;
           
            // Step 1
            if (Year % 4 == 0)
            {
                // Step 2
                if (Year % 100 == 0)
                {
                    // step 3
                    if (Year % 400 == 0)
                    {
                        isLeap = true;
                    }
                  
                }
                else
                {
                    isLeap = true;
                }
            }
          
            if (isLeap)
            {
                Console.WriteLine("Leap");
            }
            else
            {
                Console.WriteLine("Common");
            }
        }
    }
}
