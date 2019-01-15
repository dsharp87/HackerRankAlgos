using System;
using System.Collections.Generic;

namespace bonAppetit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        static void costCalc(List<int> bill, int k, int b)
        {
            int sum = 0;
            foreach(int item in bill)
            {
                sum+= item;
            }
            int amount = (sum - bill[k])/2;
            if (amount == b)
            {
                System.Console.WriteLine("Bon Appetit");
            }
            else
            {
                System.Console.WriteLine(b- amount);
            }
        }
    }


}
