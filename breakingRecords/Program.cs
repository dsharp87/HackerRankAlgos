using System;

namespace breakingRecords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static int[] brokenCount(int[] scores)
        {
            int[] breakCount = new int[]{0,0};
            int min = scores[0];
            int max = scores[0];
            foreach(int i in scores)
            {
                if(i < min)
                {
                    min = i;
                    breakCount[1]++;
                    continue;
                }
                if(i > max)
                {
                    max = i;
                    breakCount[0]++;
                    continue;
                }
            }
            return breakCount;
        }
    }
}
