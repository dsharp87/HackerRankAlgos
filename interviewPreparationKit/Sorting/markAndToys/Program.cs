using System;

namespace markAndToys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static int maximumToys(int[] prices, int k) 
        {
            prices = QSort(prices,0,prices.Length -1);
            int sum = 0;
            int count = 0;
            foreach(int val in prices)
            {
                if(sum + val <= k)
                {
                    sum+= val;
                    count++;
                }
                else
                    break;
            }
            return count;
        }

        public static int[] QSort(int[] arr, int low, int high)
        {   
            if(low < high)
            {
                int p = partition(arr, low, high);
                QSort(arr, low, p - 1);
                QSort(arr, p + 1, high);
            }
            return arr;
        }

        public static int partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int s = low - 1;
            for(int i = low; i < high; i++)
            {
                if(arr[i] <= pivot)
                {
                    s++;
                    int temp = arr[s];
                    arr[s] = arr[i];
                    arr[i] = temp;
                }
            }
            arr[high] = arr[s+1];
            arr[s+1] = pivot;
            return s+1;
        }

    }
}
