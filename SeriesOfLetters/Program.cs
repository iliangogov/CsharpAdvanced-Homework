using System;
using System.Text;
namespace SeriesOfLetters
{
    class Program
    {
        static void Main()
        {
            // Input - string of letters
            var input = Console.ReadLine();

            var output = new StringBuilder();

            output.Append(input[0]);

            foreach (char letter in input)
            {
                char prevLetter = output[output.Length - 1];

                // if current letter is not 
                // actually a letter skip
                // maybe ? 
                if (!char.IsLetter(letter))
                {
                    continue;
                }

                if (letter == prevLetter)
                {
                    continue;
                }
                else
                {
                    output.Append(letter);
                }
            }

            Console.WriteLine(output);
        }
    }
}
