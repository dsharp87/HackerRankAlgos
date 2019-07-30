using System;

namespace arrLeftRotate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static int[] rotLeft(int[] a, int d) {

            d = d % a.Length;
            int[] rotVals = new int[d];
            for(int i = 0; i < d; i++)
            {
                rotVals[i] = a[i];
            }
            for(int i = 0; i < a.Length - d; i++)
            {
                a[i] = a[i+d];
            }
            for(int i = 0; i < rotVals.Length; i++)
            {
                a[a.Length - d + i] = rotVals[i];
            }
            return a;
        }
    }
}
