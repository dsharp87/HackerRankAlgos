using System;

namespace greedyFlorist
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] c = new int[]{390225,426456,688267,800389,990107,439248,240638,15991,874479,568754,729927,980985,132244,488186,5037,721765,251885,28458,23710,281490,30935,897665,768945,337228,533277,959855,927447,941485,24242,684459,312855,716170,512600,608266,779912,950103,211756,665028,642996,262173,789020,932421,390745,433434,350262,463568,668809,305781,815771,550800};
            int res = getMinimumCost(3, c);
        }

        static int getMinimumCost(int k, int[] c) {
            //sort the array
            //have an index counter 
            //have a multiplier counter
            //have a flower per person counter
            Array.Sort<int>(c, 
                new Comparison<int>((i1, i2) => i2.CompareTo(i1))
            );
            int total = 0;
            int multiplier = 1;
            for(int i = 0; i < c.Length; i++)
            {
                total+= multiplier*c[i];
                if((i+1)%k == 0 && i != 0)
                    multiplier++;
            }
            return total;
        }

    }
}
