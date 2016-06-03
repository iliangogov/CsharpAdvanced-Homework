using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();

            string win = "Correct";
            string notwin = "Incorrect";

            // Count opening and closing brackets.
            int openBrackets = 0;
            int closeBrackets = 0;
            // check if expresion starts with closeBrackets or ends with openBrackets;
            int openIndex = userInput.IndexOf('(');
            int closeIndex = userInput.IndexOf(')');
            if (closeIndex < openIndex||userInput.LastIndexOf('(')>userInput.LastIndexOf(')'))
            {
                Console.WriteLine(notwin);
            }
            else
            {
                for (int i = 0; i < userInput.Length; i++)
                {
                    if (userInput[i] == '(')
                    {
                        openBrackets++;

                        continue;
                    }

                    if (userInput[i] == ')')
                    {
                        closeBrackets++;

                        continue;
                    }
                }

                // Check if each Opening Bracket has a matching 
                // closing bracket - regardless of whether the 
                // expression is correct.
                if (openBrackets == closeBrackets)
                {
                    Console.WriteLine(win);
                }
                else
                {
                    Console.WriteLine(notwin);
                }
            }
        }
    }
}
