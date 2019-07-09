using System;

namespace binarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] a = new int[]{1,3,6,7,10,15,17,19,25,62,77};
            int result = bSearch(a, 5, 0, a.Length-1);
            System.Console.WriteLine(result);
        }
        public static int bSearch(int[] arr, int val, int low, int high)
        {
            int mid  = (low + high)/2;
            if(arr[mid] == val)
            {
                return mid;
            }
            else if(low >= high)
            {
                return -1;
            }
            else if(val > arr[mid])
            {
                return bSearch(arr, val, mid + 1, high);
            }
            else
            {
                return bSearch(arr, val, low, mid - 1);
            }

        }
    }



}
