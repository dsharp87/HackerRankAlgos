using System;

namespace nonDivSub
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] S = new int[]{1,2,3,4,5};
            int k = 1;
            nonDivisibleSubset(k, S);
        }
        static int nonDivisibleSubset(int k, int[] S)
        {
            //make a list of mods of all numbers (do this in place)
            //make a list of mods of k that are added
            //the max size of the list can be k/2?? maybe k/2 + 1

            //create the count of mods, at their position
            //start from each end
            int[] modCounts = new int[k];
            foreach(int val in S)
            {
                modCounts[val%k]++;
            }
            int max = 0;
            for(int i = 1; i < k/2; i++)
            {
                int left = modCounts[i];
                int right = modCounts[k - i];
                max += Math.Max(left, right);
            }
            if(k%2 == 0 && S[k/2] > 0)
            {
                max++;
            }
            else if(k%2 == 1 && k != 1)
            {
                max += Math.Max(modCounts[k/2], modCounts[k/2 + 1]);
            }
            else if(k == 1 && modCounts[0] > 0)
            {
                max = 1;
            }
            if(k != 1 && modCounts[0] > 0)
            {
                max ++;
            }
            return max;
        }
    }
}
