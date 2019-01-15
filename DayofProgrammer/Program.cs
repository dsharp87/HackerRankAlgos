using System;

namespace DayofProgrammer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        //check for if 1700 - 1917/1918/1919 - 2700
        //1700-1917, only /4
        //1918, +13 days because it was skipped
        //1919 - 2700, /4 but not 100, or 400
        static string day256(int y)
        {
            string daynum256;
            if(y < 1918 && y >= 1700 && y % 4 == 0)
            {
                daynum256 = "12.09." + y.ToString();
            }
            else if(y >= 1919 && y <= 2700 && ((y % 4 == 0 && y % 100 != 0) || y % 400 == 0))
            {
                daynum256 = "12.09." + y.ToString();
            }
            else if(y == 1918)
            {
                daynum256 = "26.09." + y.ToString();
            }
            else
            {
                daynum256 = daynum256 = "13.09." + y.ToString();
            }
            return daynum256;
        }

    }
}
