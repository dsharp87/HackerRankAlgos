using System;

namespace minSwaps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] test = new int[]{7,1,3,2,4,5,6};
            int result = minimumSwaps(test);
            System.Console.WriteLine(result);
        }

        static int minimumSwaps(int[] arr) {
            int swaps = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                while(arr[i] != i+1)
                {
                   int temp = arr[i];
                   arr[i] = arr[arr[i] - 1];
                   arr[temp - 1] = temp;
                   swaps++;
                }
            }
            return swaps;
        }    
    }
}
