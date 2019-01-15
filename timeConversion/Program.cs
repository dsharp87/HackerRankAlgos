using System;

namespace timeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "12:01:00PM";
            string result = timeConversion(input);
            System.Console.WriteLine(result);
        }

        static string timeConversion(string s)
        {
            string converted;
            char tz = 'A';
            //parse the last two to find am/pm
            if(s[8] == tz)
            {
                if(Int32.Parse(s.Substring(0,2)) == 12)
                {
                    converted = "00" + s.Substring(2,6);
                }
                else
                {
                    converted = s.Substring(0,8);
                }
            }
            else
            {
                if(Int32.Parse(s.Substring(0,2)) == 12)
                {
                  converted = s.Substring(0,8);  
                }
                else
                {
                    int hour = Int32.Parse(s.Substring(0,2)) + 12;
                    converted = hour.ToString() + s.Substring(2,6);
                }
            }
            //if am, slice off last two digits and return
            //if pm, add current time to 12:00:00
            //this should just mean ad the hours section and keep the rest
            return converted;
        }
    }
}
