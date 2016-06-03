using System;
namespace NumbersAsArray
{
    class Program
    {
        static int InputToNumber(int length)
        {
            int arrToNum=0;
            int[] arr = new int[length];
            arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);
           
            for(int i=length-1;i>=0;i--)
            {
                arrToNum += arr[i] % 10;
                if (i != 0)
                {
                    arrToNum *= 10;
                }
            }

            return arrToNum;

        }
         
        static void Main()
        {
            int[] size = new int[2];
            size = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);
            int firstSize = size[0];
            int secondSize = size[1];
            int firstNum = InputToNumber(firstSize);
            int secondNum = InputToNumber(secondSize);
            int sum = firstNum + secondNum;
            int digitsInSum=0;
            while(sum>0)
            {
                sum/=10;
                digitsInSum++;
            }
             sum = firstNum + secondNum; 
            for (int i=0;i<digitsInSum;i++)
            {
                if (i == 0)
                {
                    Console.Write(sum % 10);
                    sum /= 10;
                }
                else
                {
                    Console.Write(" " + sum % 10);
                    sum /= 10;
                }
            }
            Console.WriteLine();
        }
    }
}
