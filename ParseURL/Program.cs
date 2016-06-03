using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ParseURL
{
    class Program
    {
        static void Main()
        {
          

            var format = new string[]
            {
                "[protocol] = {0}",
                "[server] = {0}",
                "[resource] = /{0}"
            };

            var toParse = Console.ReadLine();

            //var URLPattern = new Regex(@"(?<Protocol>\w+)://(?<Server>[\w\.]+)(?<Content>/.*)");

            // Expressions in Brackets are captured in groups.
            // Anything outside of the brackets is matched but 
            // not captured.
            // Optionally can name each group with <Name>
            // 
            var URLPattern = (@"(\w*)://(.*)/(.*)");

            var Match = Regex.Match(toParse, URLPattern, RegexOptions.RightToLeft);

            var toPrint = new List<object>();

            foreach (var group in Match.Groups)
            {
                if (group.ToString() != toParse)
                {
                    toPrint.Add(group);
                }
            }

            for (int index = 0; index < 3; index++)
            {
                Console.WriteLine(string.Format(format[index], toPrint[index]));
            }
        }
    }
}
