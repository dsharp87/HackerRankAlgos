using System;
using System.Linq;

namespace hurdleRace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

            static int hurdleRace(int k, int[] height) {
                int max = height.Max();
                if(max > k)
                {
                    return max - k;
                }
                else
                {
                    return 0;
                }
            }
    }
}
