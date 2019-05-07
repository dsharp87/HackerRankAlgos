using System;

namespace Find_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int t1 = 12;
            int t2 = 1012;
            System.Console.WriteLine(findDigits(t1));
            System.Console.WriteLine(findDigits(t2));
        }


        static int findDigits(int n) 
        {
            string stringVal = n.ToString();
            int count = 0;
            for(int i = 0; i < stringVal.Length; i++)
            {
                int val = Convert.ToInt32(stringVal[i]) - 48;
                if(val != 0 && n % val == 0)
                {
                    count++;
                }
            }
            return count;
        }


        // static int findDigits(int n) {

        //     int mag = n % 10 + 1;
        //     int[] vals = new int[mag];
        //     for(int i = 1; i <= mag; i++)
        //     {
        //         vals[i-1] = n % (int)Math.Pow(10, i);
        //     }
        //     return 1;
        // }
    }
}
