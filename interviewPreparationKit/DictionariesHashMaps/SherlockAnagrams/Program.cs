using System;
using System.Collections.Generic;

namespace SherlockAnagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string s =  "ACKD";
            sherlockAndAnagrams(s);
        }

        static int sherlockAndAnagrams(string s) {
            //make an array of dictionaries
            //we want to add all possible sub strings as a new dictionary with letter counts
            //iterate through the string one character at a time
            //character is first character, don't include last character
            //iterate through the array
            //in each iteration, iterate through the rest of the substrings in the array
            //for each substring comparison, compary the key exists and counts, increasing max count if making past all checks

            int pairCount = 0;
            List<Dictionary<char,int>> subsStrings = new List<Dictionary<char,int>>();
            //counter for sub string length, then we want to get all combinations of this
            for(int i = 0; i < s.Length; i++)
            {
                int endRight = s.Length;
                if(i == 0)
                    endRight--;
                
                //for each letter we want to build all the sub strings that begin with that letter
                while(i != endRight)
                {
                    
                }



                Dictionary<char,int> subRight = new Dictionary<char,int>();
                for(int j = i; j < endRight; j++)
                {
                    if(!subRight.ContainsKey(s[j]))
                    {
                        subRight.Add(s[j],1);
                    }
                    else
                    {
                        subRight[s[j]] += 1;
                    }
                }
                subsStrings.Add(subRight);





                // Dictionary<char,int> subLeft = new Dictionary<char,int>();
                // int endLeft = 0;
                // if(i == 0)
                //     endLeft++;
                // for(int k = s.Length - 1 - i; k >= endLeft; k--)
                // {
                //     if(!subLeft.ContainsKey(s[k]))
                //     {
                //         subLeft.Add(s[k],1);
                //     }
                //     else
                //     {
                //         subLeft[s[k]] += 1;
                //     }
                // }
                // subsStrings.Add(subLeft);
            }
            System.Console.WriteLine("checking");
            return 1;
        }

    }
}
