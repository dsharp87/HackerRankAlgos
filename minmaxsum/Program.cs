using System;

namespace minmaxsum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {256741038,623958417, 467905213, 714532089, 938071625};
            miniMaxSum(arr);
        }

        static void miniMaxSum(int[] arr) {
            int min = arr[0];
            int max = arr[0];
            long sum = arr[0]; //SAMPLE NUMBERS WERE SO BIG THEY ROLLED OVER TO NEGATIVE NUMBERS, THUS USE LONG
            for (int i = 1; i < arr.Length; i++)
            {
                System.Console.WriteLine(sum);
                sum += arr[i];
                System.Console.WriteLine(sum);
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine(sum + " " + min + " " + max);
            Console.WriteLine((sum - max) + " " + (sum - min));
        }
    }
}
