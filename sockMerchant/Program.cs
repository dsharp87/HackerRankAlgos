using System;
using System.Collections.Generic;

namespace sockMerchant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] socks = {1, 1, 3, 1, 2, 1, 3, 3, 3, 3};
            System.Console.WriteLine(sockPairer(10, socks));
        }

        static int sockPairer(int n, int[] ar)
        {
            int pairCount = 0;
            List<int> pairs = new List<int>();
            foreach(int sock in ar)
            {
                if(pairs.Contains(sock))
                {
                    pairCount++;
                    pairs.Remove(sock);
                }
                else
                {
                    pairs.Add(sock);
                }
            }
            return pairCount;
        }
    }
}
