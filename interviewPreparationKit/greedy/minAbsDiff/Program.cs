using System;
using System.Collections.Generic;

namespace minAbsDiff
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] arr = new int[]{3,-7,0};
            int res = minimumAbsoluteDifference(arr);
        }

            //brute force, trying to elimate duplicate evaluations and auto return if the same value is found
            static int minimumAbsoluteDifference(int[] arr) {
                int min = Math.Abs(arr[0] - arr[1]);
                List<int> checkedVals = new List<int>();
                for(int i = 0; i < arr.Length -1 ; i++)
                {
                    int val1 = arr[i];
                    if(checkedVals.Contains(val1))
                        continue;
                    checkedVals.Add(val1);
                    for(int j = i + 1; j < arr.Length; j++)
                    {
                        int val2 = arr[j];
                        if(val1 == val2)
                            return 0;
                        if(Math.Abs(val1 - val2) < min)
                            min = Math.Abs(val1 - arr[j]);
                    }
                }
                return min;
            }

            //sorted is faster for sure!
            static int minimumAbsoluteDifference2(int[] arr) {
                Array.Sort(arr);
                int min = Math.Abs(arr[0] - arr[1]);
                for(int i = 1; i < arr.Length - 1; i++)
                {
                    if(arr[i] == arr[i+1])
                        return 0;
                    if(Math.Abs(arr[i] - arr[i+1]) < min)
                        min = Math.Abs(arr[i] - arr[i+1]);
                }
                return min;
            }
    }
}
