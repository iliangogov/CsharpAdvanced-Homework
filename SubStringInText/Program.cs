using System;
namespace SubStringInText
{
    class Program
    {
        static void Main()
        {
            string find = Console.ReadLine().ToLower();
            string text = Console.ReadLine().ToLower();
            int counter = 0;
            
            for(int index=0;index<=text.Length-find.Length;index++)
            {
                if (text.Substring(index,find.Length)== find) //ako substringa ot dadeniq text s nachalo tekusht.index i krai find.length...
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
