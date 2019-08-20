using System;

namespace countInversions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }


        static long countInversions(int[] arr) {
            long swaps = 0;
            bool hasSwapped = true;
            while (hasSwapped)
            {
                hasSwapped = false;
                for(int i = 0; i < arr.Length - 1; i++)
                {
                    
                    if(arr[i] > arr[i+1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i+1];
                        arr[i + 1] = temp;
                        swaps++;
                        hasSwapped = true;
                    }
                }
            }
            return swaps;
        }
    }
}
