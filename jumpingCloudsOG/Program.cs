using System;

namespace jumpingCloudsOG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] c = new int[]{0,0,1,0,0,1,0};
            jumpingOnClouds(c);
        }

        static int jumpingOnClouds(int[] c) {
            int jumpCount = 0;
            int pos = 0;
            while(pos < c.Length - 1)
            {
                if(pos + 2 < c.Length)
                {
                    if(c[pos + 2] == 0)
                    {
                        pos+= 2;
                    }
                    else
                    {
                        pos++;
                    }
                }
                else
                {
                    pos++;
                }
                jumpCount++;
            }
            return jumpCount;
        }
    }
}
