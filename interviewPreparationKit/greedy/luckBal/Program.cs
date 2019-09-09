using System;
using System.Collections.Generic;

namespace luckBal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[][] contests = new int[][]
            {
                new int[]{5,1},
                new int[]{2,1},
                new int[]{1,1},
                new int[]{8,1},
                new int[]{10,0},
                new int[]{5,0}
            };
            int res = luckBalance(3, contests);
        }

            static int luckBalance(int k, int[][] contests) {

                int bal = 0;
                List<int> imps = new List<int>();
                foreach(int[] c in contests)
                {
                    bal+= c[0];
                    if(c[1] == 1)
                        imps.Add(c[0]);
                }
                imps.Sort();
                int wins = imps.Count - k;
                for(int i = 0; i < wins; i++)
                {
                    bal -= imps[i] * 2;
                }
                return bal;
            }

    }
}
