using System;

namespace repeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static long repeatedString(string s, long n) 
        {
            //count the number of a's in a in string s, 
            int aCountInString = 0;
            foreach(char c in s)
            {
                if(c == 'a')
                {
                    aCountInString++;
                }
            }
            long remaining = n % s.Length;
            int extraA = 0;
            for(int i = 0; i < remaining; i++)
            {
                if(s[i] == 'a')
                {
                    extraA++;
                }
            }
            long totalCount = n/s.Length*aCountInString + extraA;
            return totalCount;
        }
    }
}
