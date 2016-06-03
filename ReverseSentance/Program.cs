using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseSentance
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sentance = Console.ReadLine().Split(' ');
            string last = sentance[sentance.Length - 1];       //prepinatelniq znak na kraq na izrechenieto
            char sentanceEnd = last[last.Length - 1];          //eto go
            StringBuilder reversed = new StringBuilder();
            for (int i = sentance.Length-1; i >= 0; i--)
            {
                reversed.Append(sentance[i].Trim('.','!','?')+' ');
            }
            string reversedStr = reversed.ToString();

            Console.WriteLine(reversedStr.Trim()+sentanceEnd);

            //// Sentence to Reverse.
            //var toReverse = Console.ReadLine();

            //var Punctuation = new char[]
            //{
            //    '.',
            //    ',',
            //    '!',
            //    '?',
            //    ' ',
            //    ':',
            //    ';',
            //};

            //// Break the sentence into words to insert
            //var Words = toReverse
            //    .Trim()
            //    .Split(
            //        Punctuation,
            //        StringSplitOptions.RemoveEmptyEntries)
            //    .ToArray();

            //var toInsert = Words.Length - 1;

            //var output = new StringBuilder();

            //for (int curIndex = 0; curIndex < toReverse.Length; curIndex++)
            //{
            //    if (Punctuation.Contains(toReverse[curIndex]))
            //    {
            //        output.Append(Words[toInsert--]);

            //        if (toReverse[curIndex] != ' ')
            //        {
            //            output.Append(toReverse[curIndex]);
            //            output.Append(" ");
            //            curIndex++;
            //        }
            //        else
            //        {
            //            output.Append(" ");
            //        }
            //    }
            //}

            //Console.WriteLine(output);
        }
    }
}
