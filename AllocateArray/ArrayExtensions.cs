using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllocateArray
{
    public static class ArrayExtensions
    {
        internal static long TotalSum(this int[] arr)
        {
            int count = arr.Length;
            if (count == 0)
            {
                return 0;
            }

            long sum = 0;
            for (int i = 0; i < count; i++)
            {
                //TODO validate if long limit is reached
                sum += arr[i];
            }

            return sum;
        }

        internal static double AverageValue(this int[] arr)
        {
            double count = (double)arr.Length;
            if(count == 0)
            {
                return 0;
            }

            return arr.Sum() / count;
        }
    }
}
