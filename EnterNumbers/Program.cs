using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterNumbers
{
    class Program
    {
        static void Main()
        {
            int start = 1;
            bool increasing = true;
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    int currDigit = int.Parse(Console.ReadLine());
                    increasing = currDigit < start;
                    if (increasing) 
                
                }
            }
            catch (Exception right)
            {

                Console.WriteLine("Excaption");
            }

        }
    }
}
