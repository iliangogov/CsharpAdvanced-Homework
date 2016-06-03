using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var NewDictionary = new Dictionary<string, string>()
            {
                { ".NET", "platform for applications from Microsoft" },
                { "CLR", "managed execution environment for .NET" },
                { "namespace", "hierarchical organization of classes" }
            };

            var input = Console.ReadLine();

            Console.WriteLine(NewDictionary[input]);
        }
    }
}
