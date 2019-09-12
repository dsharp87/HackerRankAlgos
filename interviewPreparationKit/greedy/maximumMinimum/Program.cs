using System;
using System.Collections;

namespace maximumMinimum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] arr = new int[]{1,
                2,
                3,
                4,
                10,
                20,
                30,
                40,
                100,
                200};
            int res = maxMin(4, arr);
        }

        static int maxMin(int k, int[] arr) {
            //sort the array
            //iterate storing min value where val at idx - val ad idx (k-1) before
            Array.Sort(arr);
            int res = arr[k-1] - arr[0];
            for(int i = k; i < arr.Length; i++)
                res = arr[i] - arr[i-(k-1)] < res ? arr[i] - arr[i-(k-1)] : res;
            return res;
        }
    }
}
