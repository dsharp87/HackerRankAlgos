using System;
using System.Numerics;

namespace Extra_Long_Factorials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

            static void extraLongFactorials(int n) {
                BigInteger val = n;
                for(int i = n - 1; i > 1; i--)
                {
                    val = val * i;
                }
                System.Console.WriteLine(val);
            }
    }
}
