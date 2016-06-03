using System;
using System.Linq;
using System.Collections;

namespace LargestAreaInMatrix
{
    class LargestAreaInMatrix2
    {
        static BitArray[] isChecked;

        static void Main()
        {
            short[] Sizes = Console.ReadLine()
                                   .Trim(' ')
                                   .Split(' ')
                                   .Select(short.Parse)
                                   .ToArray();
            int[][] toSearch = new int[Sizes[0]][];
            isChecked = new BitArray[toSearch.Length];

            for (int Row = 0; Row < toSearch.Length; Row++)
            {
                toSearch[Row] = Console.ReadLine()
                                       .Trim(' ')
                                       .Split(' ')
                                       .Select(int.Parse)
                                       .ToArray();
                isChecked[Row] = new BitArray(toSearch[Row].Length);
            }
            var MaxSequence = int.MinValue;
            for (int Row = 0;
                     Row < toSearch.Length;
                     Row++)
            {
                for (int Col = 0;
                         Col < toSearch[Row].Length;
                         Col++)
                {
                    int curSequence = 1;

                    if (isChecked[Row][Col] == false)
                    {
                        isChecked[Row][Col] = true;
                        curSequence = CheckElement
                                      (
                                        Row,
                                        Col,
                                        curSequence,
                                        toSearch
                                      );
                    }
                    MaxSequence = curSequence > MaxSequence ?
                                  curSequence : MaxSequence;
                }
            }
            Console.WriteLine(MaxSequence);
        }
        public static int CheckElement
                          (
                            int Row,
                            int Col,
                            int curSequence,
                            int[][] toSearch
                          )
        {
            if (Row + 1 < toSearch.Length)
            {
                if (toSearch[Row + 1][Col] ==
                    toSearch[Row][Col] &&
                    isChecked[Row + 1][Col] == false)
                {
                    curSequence++;

                    isChecked[Row + 1][Col] = true;

                    curSequence = CheckElement
                                  (
                                      Row + 1,
                                      Col,
                                      curSequence,
                                      toSearch
                                  );
                }
            }
            if (Col + 1 < toSearch[Row].Length)
            {
                if (toSearch[Row][Col + 1] ==
                    toSearch[Row][Col] &&
                    isChecked[Row][Col + 1] == false)
                {
                    curSequence++;

                    isChecked[Row][Col + 1] = true;

                    curSequence = CheckElement
                                  (
                                      Row,
                                      Col + 1,
                                      curSequence,
                                      toSearch
                                  );
                }
            }
            if (Row - 1 >= 0)
            {
                if (toSearch[Row - 1][Col] ==
                    toSearch[Row][Col] &&
                    isChecked[Row - 1][Col] == false)
                {
                    curSequence++;

                    isChecked[Row - 1][Col] = true;

                    curSequence = CheckElement
                                  (
                                      Row - 1,
                                      Col,
                                      curSequence,
                                      toSearch
                                  );
                }
            }
            if (Col - 1 >= 0)
            {
                if (toSearch[Row][Col - 1] ==
                    toSearch[Row][Col] &&
                    isChecked[Row][Col - 1] == false)
                {
                    curSequence++;

                    isChecked[Row][Col - 1] = true;

                    curSequence = CheckElement
                                  (
                                      Row,
                                      Col - 1,
                                      curSequence,
                                      toSearch
                                  );
                }
            }
            return curSequence;
        }
    }
}