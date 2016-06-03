using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            var buildOutput = new StringBuilder(20);
            string userInput = Console.ReadLine();

            buildOutput.Append(userInput);

            while (buildOutput.Length < 20)
            {
                buildOutput.Append("*");
            }

            Console.WriteLine(buildOutput);
        }
    }
}
