using System;

namespace divisibleSumPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        //nestted loop
        static int divisibleSumPairs(int n, int k, int[] ar)
        {
            int count = 0;
            for(int i = 0; i < (ar.Length - 1); i++)
            {
                for(int j = i + 1; j < ar.Length; j++)
                {
                    if((ar[i] + ar[j]) % k == 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
