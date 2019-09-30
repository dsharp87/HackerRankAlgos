using System;
using System.Collections.Generic;

namespace hashIceCream
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] cost = new int[]{1,4,5,3,2};
            whatFlavors(cost, 4);
        }

        static void whatFlavors(int[] cost, int money) {
            //make dictionary with distinct values
            //iterate through, checking if key of needed second value exists
            //if it doesn't, make this value

            Dictionary<int,int> vals = new Dictionary<int, int>();
            int current = 0;
            int second = 0;
            for(int i = 0; i < cost.Length; i++)
            {
                int val = cost[i];
                if(vals.ContainsKey(money - val))
                {
                    current = i+1;
                    second = vals[money-val];
                    break;
                }
                else
                    vals[val] = i+1;
            }
            if(current > second)
            {
                int temp = second;
                second = current;
                current = temp;
            }
            System.Console.WriteLine(current + " " + second);
        }
    }
}
