using System;

namespace Sequence_Equation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }


            static int[] permutationEquation(int[] p) {
                //itterate from 1 - x
                //for each iterations, check value that returns iterator
                //then check value that returns that value

                int[] result = new int[p.Length];
                for(int i = 1; i <= p.Length; i++)
                {
                    int x = Array.IndexOf(p, i) + 1;
                    int y = Array.IndexOf(p, x) + 1;
                    result[i -1] = y;
                }
                return result;
            }
    }
}
