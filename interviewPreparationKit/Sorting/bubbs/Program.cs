using System;

namespace bubbs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] swippyswap = new int[]{5,87,1,34,87,4,213,7,789,34,12};
            booblywooblyswappywappy(swippyswap);
            System.Console.WriteLine("done");
        }

            static void booblywooblyswappywappy(int[] a)
            {
                bool hasSwapped = true;
                int swapCount = 0;
                while(hasSwapped)
                {
                    hasSwapped = false;
                    for(int i = 0; i < a.Length-1; i++)
                    {
                        if(a[i] > a[i + 1])
                        {
                            hasSwapped = true;
                            int temp = a[i];
                            a[i] = a[i+1] ;
                            a[i+1]= temp;
                            swapCount++;
                        }
                    }
                }
                System.Console.WriteLine("Array is sorted in {0} swaps.",swapCount);
                System.Console.WriteLine("First Element: {0}",a[0]);
                System.Console.WriteLine("Last Element: {0}",a[a.Length-1]);
            }

    }
}
