using System;

namespace NewYearChaos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] q = new int[]{5,1,2,3,7,8,6,4};
            minimumBribes(q);
            q = new int[]{1,2,5,3,7,8,6,4};
            minimumBribes(q);
        }

            static void minimumBribes(int[] q) {

            int min = 0;
            //start at back, looking at each value for 2 thigns, is it too far forward, and if not, how many numbers are larger than it to the left
            for(int i = q.Length - 1; i >= 0; i--)
            {
                //is it too many places to the left of where it started (bribed more than 2 times)
                if(q[i] - (i+1) > 2)
                {
                    System.Console.WriteLine("Too chaotic");
                    return;
                }
                //start at least 2 bribes before where this value would have sat, then check all values bewtween those boundaries, to see if they bribed current val at some point
                for(int j = Math.Max(0, q[i] - 2); j < i; j++)
                {
                    if(q[j] > q[i])
                        min++;
                }
            }
            System.Console.WriteLine(min);
            return;
        }
    }
}
