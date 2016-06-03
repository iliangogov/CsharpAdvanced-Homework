using System;
namespace IndexOfLetters
{
    class Program
    {
        static void Main()
        {
            char[] azbuka = new char[26];
            for (int i = 0; i < azbuka.Length; i++)
            {
                azbuka[i] = (char)('a' + i);
            }
            string duma = Console.ReadLine().ToLower();
            foreach (char bukva in duma)
            {
                for (int i = 0; i < azbuka.Length; i++)
                {
                    if (bukva == azbuka[i])
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}
