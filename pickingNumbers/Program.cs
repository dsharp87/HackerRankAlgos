using System;
using System.Collections.Generic;

namespace pickingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>{4,6,5,3,3,1};
            int result = numberPicker(a);
        }

        public static int numberPicker(List<int> a)
        {
            int[] numberHash = hashMaker(a);
            int maxCount = 0;
            for(int i = 0; i < numberHash.Length - 1; i++)
            {
                if(numberHash[i] + numberHash[i+1] > maxCount)
                {
                    maxCount = numberHash[i] + numberHash[i+1];
                }
            }
            return maxCount;
        }

        public static int[] hashMaker(List<int> a )
        {
            int[] hash = new int[100];
            foreach(int val in a)
            {
                hash[val-1] +=1;
            }
            return hash;
        }


    }
}
