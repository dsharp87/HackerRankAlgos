using System;
using System.Collections.Generic;
using System.Linq;

namespace minmaxriddle
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] input = new long[] {16,5,20,6,80};
            riddle(input);
        }

        //elegant version
        //USE A QUEUE BECAUSE THIS IS STACKS AND QUEUS
        //aparently this is not the way to go, need stacks in some way
        static long[] riddle(long[] arr) 
        {
            // PrintIndexAndValues(arr);
            //need a output array
            long[] output = new long[arr.Length];

            //edge case only single value
            if(arr.Length == 1)
            {
                return arr;

            // for first and last, can just pull the max and min value respectively
            } else if(arr.Length >= 2) {
                output[0] = arr.Max();
                output[arr.Length - 1] = arr.Min();
            }
            
            //looping through remaining windows, where i is window size
            for(int i=2; i <= arr.Length -1; i++)
            { 
                System.Console.WriteLine("loop " + (i-1));
                //need a running value of current max min
                long maxMin = arr[0];

                long currentMin = arr[0];

                //need queue to hold values
                Queue<long> q = new Queue<long>();
                q.Enqueue(arr[0]);
                //add initial values
                for(int j = 1; j < i; j++)
                {
                    maxMin = arr[j] < maxMin ? arr[j] : maxMin;
                    currentMin = arr[j] < currentMin ? arr[j] : currentMin;
                    q.Enqueue(arr[j]);
                    System.Console.WriteLine("maxMin = " + maxMin + " currentMin = " + currentMin + " and j = " + j);
                }
                for (int j = i; j < arr.Length; j++)
                {
                    q.Enqueue(arr[j]);
                    //if the incoming value is smaller, then current min needs to get overwritten, does affect maxmin
                    if(arr[j] < currentMin)
                    {
                        currentMin = arr[j];
                    }
                    //if the outgoing value is the current min, need to know what new min is
                }

            } 
            
            return output;
        }


        //THIS SOLUTION IS BRUTE FORCE, AND DOESN'T PASS TIME LIMIT CHECKS
        static long[] riddleBrute(long[] arr) 
        {
            // PrintIndexAndValues(arr);
            //need a output array
            long[] output = new long[arr.Length];

            //edge case only single value
            if(arr.Length == 1)
            {
                return arr;

            // for first and last, can just pull the max and min value respectively
            } else if(arr.Length >= 2) {
                output[0] = arr.Max();
                output[arr.Length - 1] = arr.Min();
            }
            
            //looping through remaining windows, where i is window size
            for(int i=2; i <= arr.Length -1; i++)
            { 
                
                //need a running value of current max min
                long maxMin = 0;

                for(int j = 0; j <= arr.Length - i; j++)
                {
                    // PrintIndexAndValues(new ArraySegment<long>(arr, j,i));
                    long min = new ArraySegment<long>(arr, j,i).Min();
                    // System.Console.WriteLine("current min is " + min.ToString());
                    maxMin = min > maxMin ? min : maxMin;
                }
                output[i-1] = maxMin;
                // PrintIndexAndValues(output);
            } 
            
            return output;
        }

        public static void PrintIndexAndValues( ArraySegment<long> arrSeg )  {
            for ( int i = arrSeg.Offset; i < (arrSeg.Offset + arrSeg.Count); i++ )  {
                Console.WriteLine( "   [{0}] : {1}", i, arrSeg.Array[i] );
            }
            Console.WriteLine();
        }

        public static void PrintIndexAndValues( long[] myArr )  {
            for ( int i = 0; i < myArr.Length; i++ )  {
                Console.WriteLine( "   [{0}] : {1}", i, myArr[i] );
            }
            Console.WriteLine();
        }
    }
}
