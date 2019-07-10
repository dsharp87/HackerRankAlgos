using System;

namespace quickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] test = new int[]{22,4,17,12,17,9,50,27,7,19};
            test = QSort(test, 0, test.Length - 1);
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
