using System;
using System.Collections.Generic;

namespace balancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static string isBalanced(string s) {

            List<char> opens = new List<char>{'{','[','('};
            List<char> closes = new List<char>{'}',']',')'};
            Stack<char> chars = new Stack<char>();
            foreach(char c in s)
            {
                if(opens.Contains(c))
                    chars.Push(c);
                else
                {
                    if(chars.Count == 0)
                        return "NO";
                    char topChar = chars.Pop();
                    int idx = closes.IndexOf(c);
                    if(opens.IndexOf(topChar) != idx)
                        return "NO";
                }
            }
            if(chars.Count > 0)
                return "NO";
            return "YES";
        }
    }
}
