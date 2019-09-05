using System;

namespace alternateChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "aabababbabbaabb";
            int res = alternatingCharacters(x);
            System.Console.WriteLine(res);
            
        }

        static int alternatingCharacters(string s) {
            int result = 0;
            char currChar = s[0];
            for(int i = 1; i < s.Length; i++) {
                if(s[i] == currChar)
                    result++;
                else
                    currChar = s[i];
            }
            return result;
        }
    }
}
