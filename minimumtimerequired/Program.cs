using System;

namespace minimumtimerequired
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] m = new long[] {2,6,13,4,23};
            minTime(m, 234);
        }

        static long minTime(long[] machines, long goal) {

            Array.Sort(machines);

            long upper_bound = (long)Math.Ceiling((double)goal/ machines.Length) * machines[machines.Length-1];
            
            long lower_bound = (long)Math.Ceiling((double)goal/ machines.Length) * machines[0];

            // System.Console.WriteLine(lower_bound.ToString() + " " + " " + upper_bound.ToString());

            long result = -1;

            while(lower_bound < upper_bound)
            {
                long mid = (lower_bound + upper_bound) / 2;

                // System.Console.WriteLine("mid is now" + mid);
                long units = 0;
                foreach(long m in machines)
                {
                    units += mid / m;
                    // System.Console.WriteLine("m is " + m + ", " + mid / m + " new units produced. Total now: " + units);
                }
                // System.Console.WriteLine("units produced = " + units + ", goal was " + goal);
                if(units < goal)
                {
                    lower_bound = mid + 1;
                    // System.Console.WriteLine("now lets search top half, or " + lower_bound + " to " + upper_bound);
                } else 
                {
                    result = mid;
                    upper_bound = mid;
                    // System.Console.WriteLine("now lets search lower half, or " + lower_bound + " to " + upper_bound);
                }
            }
            // System.Console.WriteLine(result);

            return result;
        }

    }
}
