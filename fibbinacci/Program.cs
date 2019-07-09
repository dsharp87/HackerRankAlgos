using System;

namespace fibbinacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int [] result = fibMaker(12);
            System.Console.WriteLine(rFibb(6));
            System.Console.WriteLine("done");
        }

        public static int[] fibMaker(int val)
        {
            int[] fibb = new int[val];
            fibb[1] = 1;
            for(int i = 2; i < val; i++)
                fibb[i] = fibb[i-1] + fibb[i-2];
            return fibb;
        }

        public static int rFibb(int val)
        {
            if(val == 0)
                return 0;
            if(val == 1)
                return 1;
            return rFibb(val - 2) + rFibb(val -1);
        }
    }
}
