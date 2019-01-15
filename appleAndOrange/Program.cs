using System;

namespace appleAndOrange
{
    class Program
    {
        static void Main(string[] args)
        {
            appleOrange(7,11,5,15,new int[]{-2,2,1},new int[]{5,-6});
        }

        static void appleOrange(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            int applecount = 0;
            int orangecount = 0;
            for(int i = 0; i < apples.Length; i++)
            {
                if(a + apples[i] >= s && a + apples[i] <= t)
                {
                    applecount++;
                }
            }
            for(int i = 0; i < oranges.Length; i++)
            {
                if(b + oranges[i] >= s && b + oranges[i] <= t)
                {
                    orangecount++;
                }
            }
            System.Console.WriteLine(applecount);
            System.Console.WriteLine(orangecount);
        }
    }
}
