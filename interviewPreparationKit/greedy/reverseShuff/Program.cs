using System;
using System.Collections.Generic;
using System.Linq;

namespace reverseShuff
{
    class Program
    {
        static void Main(string[] args)
        {
            // string s = "gfedcbagfedcbagfedcbagfedcba";
            string s = "djjcddjggbiigjhfghehhbgdigjicafgjcehhfgifadihiajgciagicdahcbajjbhifjiaajigdgdfhdiijjgaiejgegbbiigida";

            // String.Concat(s.OrderBy(c => c));
            reverseShuffleMerge(s);
        }



        //input string is length 2X
        //output (A) string is length X
        //input string must contains Rerse(A) in order
        //Shuffle(A) doesn't matter, as its random order
        //input will contain 2(A) of each charcter where Y is the count of that charcter in A
        //LEXAGRAPHICAL ORDER IS THE HARD PART

        public class CharMapper
        {
            public int count = 1;
            public int finalCount = 0;
            public List<int> indexes;

            public CharMapper(int firstIdx)
            {
                indexes = new List<int>(){firstIdx};
            }
        }

        static string reverseShuffleMerge(string s) {
            
            //create map of all characters, their counts, and indexes
            Dictionary<char, CharMapper> charMap = new  Dictionary<char, CharMapper>();
            for(int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if(!charMap.ContainsKey(c))
                    charMap[c] = new CharMapper(i);
                else
                {
                    charMap[c].count++;
                    charMap[c].indexes.Add(i);
                }                    
            }
            
            //divide each count in the dictionary by 2 to get character counts for A
            List<char> keys = new List<char>(charMap.Keys);
            List<char> ListChars = new List<char>();
            foreach(char c in keys)
            {
                charMap[c].finalCount = charMap[c].count/2;
                for(int i = 0; i < charMap[c].finalCount; i++)
                    ListChars.Add(c);
            }
            
            //create an ordered char array to show alphebetic hierarchy of letters to encounter
            char[] orderedChars = ListChars.ToArray();
            Array.Sort(orderedChars);

            //create ordered distinct list
            // char[] orderdistinctchars = ListChars.Distinct().ToArray();
            // Array.Sort(orderdistinctchars);

            //instantiate result string
            string result = "";
            int strLength = s.Length/2;
            
            //start iterating backwards
            for(int i = s.Length-1; i >= 0; i--)
            {
                char c = s[i];
                //did we encounter the best possible character, if so add it and remove that character from order array
                //and from dictionary of needed character counts
                if(c == orderedChars[0])
                {
                    result+= c;
                    orderedChars = orderedChars.Skip(1).ToArray();
                    charMap[c].count -= 1;
                    charMap[c].finalCount -= 1;
                }

                //is this character unskippable?
                //if so we need to add it regardless, and remove it from order array
                else if(charMap[c].count == charMap[c].finalCount)
                {
                    result += c;
                    charMap[c].count -= 1;
                    charMap[c].finalCount -= 1;
                    int numidx = Array.IndexOf(orderedChars, c);
                    orderedChars = orderedChars.Where((idx) => idx != numidx).ToArray();
                }

                //is this character skippable at first glance? 
                //are there more chacters of this string left than we need in the final string
                else if(charMap[c].count > charMap[c].finalCount)
                {    
                    //next idx of best character
                    int nextBestIdx = charMap[orderedChars[0]].indexes.Where( idx => idx < i).Max();

                    //next unskippable idx
                    int nextUnskippableIdx = -1;
            //********************************************************borken part */
                    //iterate from current point till next best 
                    int j = i - 1;
                    while(j != nextBestIdx)
                    {
                        char charToCheck = s[j];
                        if(charMap[charToCheck].count == charMap[charToCheck].finalCount)
                        {
                            nextUnskippableIdx = j;
                            break;
                        }
                        j--;  
                    }
                    j = i - 1;
                    bool breakFlag = false;
                    while(j > nextBestIdx && j > nextUnskippableIdx)
                    {
                        char charToCheck = s[j];
                        if(charToCheck < c && charMap[charToCheck].finalCount > 0)
                        {
                            breakFlag = true;
                            break;
                        }
                        //if we encounter a character that is unskippable 
                        //and is greater than this character we want to break
                        // if(charToCheck > c && charMap[charToCheck].count == charMap[charToCheck].finalCount)
                        // {
                        //     breakFlag = true;
                        //     break;
                        // }

                        // //if we encounter a character that is smaller, and we still need it, it COULD BE THE SMALLEST
                        // //WRONG
                        // else if(charToCheck < c && charMap[charToCheck].finalCount > 0)
                        // {
                        //     breakFlag = true;
                        //     break;
                        // }
                        j--;
                    }
                    if(breakFlag)
                        charMap[c].count--;
                    else 
                    {
                        result += c;
                        charMap[c].count -= 1;
                        charMap[c].finalCount -= 1;
                        int numidx = Array.IndexOf(orderedChars, c);
                        orderedChars = orderedChars.Where((idx) => idx != numidx).ToArray();
                    }
                    //********************************************************borken part */
                }
                //THERE IS A CONDITION HERE WHERE ITS BETTER TO TAKE A NON FIRST CHARACTER INSTEAD OF SKIPPING IT
                //THINK ABOUT WHY THIS COULD BE, FOR INSTANCE PUTTING A C IN WHEN THERE ARE STILL B'S TO BE FOUND
                //NEED A WAY TO TRACK THE LETTERS THAT ARE CURRENTLY UNSKIPPABLE COMPARED TO CURRENT LETTER IS ADD CURRENT LETER PREMATURELY
                //IF THE NEXT UNSKIPPABLE LETER COMES BEFORE ALL LETERS HIGHER PRIORETY THAN THE CURRENT LETTER 


                //array of indexes of 

                //best option if current character is better lexigraphical choice compared to all unskippable characters that occur before the next instance of ordered[0]
             

               
                //if we've completd the string, stop looping
                if(result.Length == strLength)
                    break;
            }      
            return result;
        }
    }
}
