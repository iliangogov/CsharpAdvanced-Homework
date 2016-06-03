using System;
using System.Linq;

namespace numbersAsArrBest
{
    class Program
    {
        static void Main()
        {
            Console.ReadLine();   

            int[] NumberOne = Console.ReadLine()                    
                              .Trim(' ') 
                              .Split(' ')                           
                              .Select(digit => int.Parse(digit))    
                              .ToArray();                           

            int[] NumberTwo = Console.ReadLine()                    
                              .Trim(' ')
                              .Split(' ')                           
                              .Select(digit => int.Parse(digit))    
                              .ToArray();   
                                    
            int[] Result = GetSum(NumberOne, NumberTwo);

            string outputString = string.Join(" ", Result);

            Console.WriteLine(outputString);
        }

        public static int[] GetSum(int[] NumberOne, int[] NumberTwo)
        {
            int[] Result = new int[Math.Max(                       
                                   NumberOne.Length,               
                                   NumberTwo.Length)];              

            int CarriedOver = 0;
            int curSum = 0;

            for (int curDigit = 0;              
                     curDigit < Math.Min(       
                         NumberOne.Length,      
                         NumberTwo.Length);     
                     curDigit++)                
            {
                curSum = 0;
                curSum = NumberOne[curDigit] +  
                         NumberTwo[curDigit] +  
                         CarriedOver;

                CarriedOver = 0;

                if (curSum > 9)     
                {                  
                    curSum %= 10;   
                    CarriedOver++;  
                }                   

                Result[curDigit] = curSum;
            }

           
            if (NumberOne.Length > NumberTwo.Length)
            {
                Result = FillEmpty(NumberOne,
                                   NumberTwo,
                                   Result,
                                   CarriedOver);
                CarriedOver = 0;
            }
            else if (NumberOne.Length < NumberTwo.Length)
            {
                Result = FillEmpty(NumberTwo,
                                   NumberOne,
                                   Result,
                                   CarriedOver);
                CarriedOver = 0;
            }

            if (CarriedOver > 0)
            {
                Array.Resize(ref Result, Result.Length + 1);
                Result[Result.Length - 1] = CarriedOver;
            }

            return Result;
        }

        public static int[] FillEmpty(
                      int[] LongerArray,
                      int[] ShorterArray,
                      int[] Result,
                      int CarriedOver)
        {
            for (int curElement = ShorterArray.Length;
                         curElement < LongerArray.Length;
                         curElement++)
            {
                Result[curElement] = LongerArray[curElement] + CarriedOver;
                CarriedOver = 0;

                if (Result[curElement] > 9)
                {
                    Result[curElement] %= 10;
                    CarriedOver++;
                }
            }

            if (CarriedOver > 0)
            {
                Array.Resize(ref Result, Result.Length + 1);
                Result[Result.Length - 1] = CarriedOver;
            }

            return Result;
        }
    }
}
