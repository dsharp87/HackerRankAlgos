using System;

namespace JumpingCloudsRevisited
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] c = new int[]{0,0,1,0,0,1,1,0};
            int k = 2;
            jumpingOnClouds(c, k);
        }

        static int jumpingOnClouds(int[] c, int k) {
            int e = 100;
            for(int i = 0; i < c.Length; i += k)
            {
                if(c[(i + k) % c.Length] == 1)
                {
                    e -= 2;
                }
                e -= 1;
            }
            return e;
        }

    }
}
