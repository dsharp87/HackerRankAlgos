using System;
using System.Collections.Generic;

namespace HashRansomNote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

        }

        static void checkMagazine(string[] magazine, string[] note) 
        {
            //make a dictionary of words
            //check if each word exists in the dictionary
            Dictionary<string, int> words = new Dictionary<string, int>();
            foreach(string word in magazine)
            {
                if(!words.ContainsKey(word))
                {
                    words.Add(word, 1);
                }
                else
                {
                    words[word] += 1;
                }
            }
            foreach(string word in note)
            {
                if(words.ContainsKey(word) && words[word] > 0)
                {
                    words[word] --;
                }
                else
                {
                    System.Console.WriteLine("No");
                    return;
                }
            }
            System.Console.WriteLine("Yes");           
        }
    }
}
