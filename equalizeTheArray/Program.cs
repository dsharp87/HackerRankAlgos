using System;
using System.Linq;

namespace equalizeTheArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static int equalizeArray(int[] arr) {
            int max = arr.Max();
            int[] counts = new int[max];
            foreach(int val in arr)
            {
                counts[val-1]++;
            }
            
            return arr.Length - counts.Max();
        }
    }
}
