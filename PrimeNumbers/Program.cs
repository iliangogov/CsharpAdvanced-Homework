using System;

class PrimeNumbers
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        bool[] bigArr = new bool[N];
        int bigestPrime = 0;
        for (int i = 0; i < bigArr.Length; i++)
        {
            bigArr[i] = true;
        }
        for (int i = 2; i <=Math.Sqrt(bigArr.Length); i++)
        {
            if (bigArr[i])
            {
                for (int j = i * i; j <= bigArr.Length; j = j + i)
                {
                    bigArr[j] = false;
                }
            }
        }

        for (int i = 0; i <bigArr.Length; i++)
        {
            if (bigArr[i])
            {
                Console.WriteLine(i+" ");
                if (i >= bigestPrime)
                {
                    bigestPrime = i;
                   
                }
            }
        }
        if(N==2)
        {
            bigestPrime = 2;
        }
        Console.WriteLine(bigestPrime);
    }
}