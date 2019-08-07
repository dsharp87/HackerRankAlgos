using System;
using System.Collections.Generic;

namespace TwoStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static string twoStrings(string s1, string s2) {
            Dictionary<char, int> chars1 = new Dictionary<char, int>();
            Dictionary<char, int> chars2 = new Dictionary<char, int>();
            foreach(char c in s1)
            {
                if(!chars1.ContainsKey(c))
                    chars1.Add(c,1);
            }
            foreach(char c in s2)
            {
                if(!chars2.ContainsKey(c))
                    chars2.Add(c,1);
            }
            foreach(KeyValuePair<char,int> c in chars1)
            {
                if(chars2.ContainsKey(c.Key))
                    return "YES";
            }
            return "NO";
        }

    }
}
