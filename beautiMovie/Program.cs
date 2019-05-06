using System;

namespace beautiMovie
{
    class Program
    {
        static void Main(string[] args)
        {
            beautifulDays(20,23,6);
        }

        static int beautifulDays(int i, int j, int k) {
            int dayCount = 0;
            for(int day = i; day <= j; day++)
            {
                if(Math.Abs(day - reverse(day)) % k == 0)
                {
                    dayCount++;
                }
            }
            return dayCount;
        }

        public static int reverse(int num)
        {
            string stringNum = num.ToString();
            string reverseStringNum = "";
            for(int i = stringNum.Length; i > 0; i--)
            {
                if(i == stringNum.Length && stringNum[i-1].ToString() == "0")
                {
                    continue;
                }
                reverseStringNum+= stringNum[i-1];
            }
            int reverseNum = Int32.Parse(reverseStringNum);
            return reverseNum;
        }
    }
}
