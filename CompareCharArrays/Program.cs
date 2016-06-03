using System;
namespace CompareCharArrays
{
    class Program
    {
        static void Main()
        {

            string first = Console.ReadLine();
            string second = Console.ReadLine();
            bool equal = true;

            for (int i = 0; i < Math.Min(first.Length, second.Length); i++)
            {

                if ((first[i] < second[i])||first.Length<second.Length)
                {
                    Console.WriteLine("<");
                    equal = false;
                    return;
                }

                if ((first[i] > second[i])||first.Length>second.Length)
                {
                    Console.WriteLine(">");
                    equal = false;
                    return;

                }

            }

                if (equal&&first.Length==second.Length)
                {
                    Console.WriteLine("=");
                }
            
        }
    }
}
