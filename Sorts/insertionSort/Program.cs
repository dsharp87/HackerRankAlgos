using System;

namespace insertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] test = new int[]{4,3,2,10,12,1,5,5,6};
            test = insertSort(test);

        }

        public static int[] insertSort(int[] arr)
        {
            for(int i = 1; i < arr.Length; i++)
            {
                int temp = arr[i];
                int ri = i;
                while(ri != 0 && temp < arr[ri - 1])
                {
                    arr[ri] = arr[ri - 1];
                    ri--;
                }
                // for(int j = i; j > 0; j--)
                // {
                //     if(temp < arr[j-1])
                //     {
                //         arr[j] = arr[j-1];
                //         ri--;
                //     }
                //     else
                //         break;
                // }
                arr[ri] = temp;
            }
            return arr;
        }
    }
}
