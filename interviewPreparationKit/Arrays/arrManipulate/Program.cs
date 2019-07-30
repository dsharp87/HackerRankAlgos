using System;

namespace arrManipulate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[][] test = new int[][]
            {
                new int[]{1,2,100},
                new int[]{2,5,100},
                new int[]{3,4,100}
            };
            long max = betterManipulate(5, test);
        }

            static long arrayManipulation(int n, int[][] queries) 
            {
                long[] vals = new long[n];
                foreach(int[] q in queries)
                {
                    for(int i = q[0] - 1; i <= q[1] - 1; i++)
                        vals[i] += q[2];
                }
                long max = 0;
                foreach(long val in vals)
                {
                    if(val > max)
                        max = val;
                }
                return max;
            }


            static long betterManipulate(int n, int[][] queries)
            {
                //this will store differences invalues
                long[] vals = new long[n];
                foreach(int[] q in queries)
                {
                    //set the first val in the range to increase by the num
                    vals[q[0] - 1] += q[2];
                    //if there exists a value after the end fo the range, subtract the number from it, indicating that its less than the nunmber before it
                    if(q[1] < n)
                        vals[q[1]] -= q[2];
                }
                long max = 0;
                long tempmax = 0;
                //we need to go throuhg the list of differences, and whenever the current sub total sum is greater than the max, we replace max;
                foreach(long val in vals)
                {
                    tempmax += val;
                    if(tempmax > max)
                        max = tempmax;
                }
                return max;
            }
    }
}
