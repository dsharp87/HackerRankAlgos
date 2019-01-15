using System;

namespace birthdaycandles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] heights = {1,4,4,3,2};
            int result = CandleBlow(heights);
            System.Console.WriteLine(result);
        }

        static int CandleBlow(int[] ar)
        {
            //need a max to remember max
            int max = ar[0];
            //need a count to remember how many
            int count = 1;
            
            //for loop to go through
                //check for new max
                //if new, reset
                //if same, ++
                //if not nothing
            for (int i = 1; i < ar.Length; i++)
            {
                if (ar[i] == max)
                {
                    count++;
                }
                else if (ar[i] > max)
                {
                    max = ar[i];
                    count = 1;
                }
            }
            return count;
        }
    }
}
