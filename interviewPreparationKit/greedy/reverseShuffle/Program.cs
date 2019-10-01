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
            string s = "sbcnzxqnrygkocahxjebvueaawwcythjdrhvizqsshgtwdolmillxpshxpxqrywkivceufclhydhshrklkphajbftuapiocjlcthfirhgaohfysqjolssbzhbovdstbyqdpnjbpfmgqrzfctcwcrztvgbegunarvecseoulabaonguckqbtrvuagreyclyjytpvozqdnhldlnsocenuzksawirgsbjobpldjdlrxbricrauuksbmecvvwagnnacaqghmjpzrlsvlpbbcuaddgvlhvuvkxexjcfhxrodmcwlrzyyiksuksshhonahsyzbbprwuitmoyoqurtqsaslevgvpfbzkkhgcnpjdpseuiylluvdetsqssbrxpiclxxvosuqipsqvvwsezhl";
            string t = "aaaaaavvcembskuabxddlpbbsgiaskucosdlhndqzovpjlcyerauvrbcugnbluescevrnubgvtzrcwccfzrqgmfpbjnpdqybtsdvobhzsslojqsyfhoghrifhtclcoiputjhpklkrhsdyhlcuevikwyrqxpxhspxllimlowtghssqzivhrjtywweuvejxokgyrnqxzns";

            // String.Concat(s.OrderBy(c => c));
            reverseShuffleMerge(s,t);
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

        static string reverseShuffleMerge(string s, string t) {
            
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
                    orderedChars = orderedChars.Where((val, idx) => idx != numidx).ToArray();
                }

                //is this character skippable at first glance? 
                //are there more characters of this string left than we need in the final string
                else if(charMap[c].count > charMap[c].finalCount && charMap[c].finalCount != 0)
                {    
                    //next idx of best character
                    int nextBestIdx = charMap[orderedChars[0]].indexes.Where( idx => idx < i).Max();

                    //next unskippable idx
                    int nextUnskippableIdx = -1;

                    //iterate from current point till next best 
                    int j = i - 1;
                    
                    //*************************************THIS IS THE IMPORTANT PART TO LOOK AT************************
                    
                    //i want to copy the mapping object here, so i can manipulate it to simulate characters being skipped
                    Dictionary<char, CharMapper> copy = new Dictionary<char, CharMapper>(charMap);
                    //need to do a DEEP CLONE, as the charmapper object is just getting copies as reference
                    //look into ICLONABLE interface
                    Dictionary<char, CharMapper> clone = charMap.ToDictionary(kv => kv.Key, kv => kv.Value.Clone() as CharMapper);
                    while(j != nextBestIdx)
                    {
                        char charToCheck = s[j];
                        //if there are only enough left to fulfill final count then its unskippable
                        if(copy[charToCheck].count == copy[charToCheck].finalCount)
                        {
                            nextUnskippableIdx = j;
                            break;
                        }
                        charMap[charToCheck].count--;
                        j--;  
                    }
                    //*************************************THIS IS THE IMPORTANT PART TO LOOK AT************************
                    j = i - 1;
                    bool breakFlag = false;
                    //for tracking purposes
                    char nextUnskippableChar = nextUnskippableIdx != -1 ? s[nextUnskippableIdx] : 'z';
                    //if the next best is closer than unskippable, or current character is worse than next unskippable
                    //THERE IS A CHARACTER THAT WILL BECOME UNSKIPPABLE BEFORE NEXT BEST, AND THIS CHARACTER IS BETTER THAN IT
                    //THE REASON ITS NOT FOUND IS THAT THERE ARE MULTIPLE INSTANCES WHAT WILL BECOME THE NEXT UNSKIPPABLE (SO ITS NOT THINKING THAT IT IS UNSKIPPABLE)
                    if(nextBestIdx >= nextUnskippableIdx || c > nextUnskippableChar)
                        breakFlag = true;
                    else
                    {
                        //we want to look for a better character than current character before we hit the idx of next best option or an unskippable
                        while(j > nextBestIdx && j > nextUnskippableIdx)
                        {
                            char charToCheck = s[j];
                            //is this character better choice? if yes we can stop looking and skip this character
                            if(charToCheck < c && charMap[charToCheck].finalCount > 0)
                            {
                                breakFlag = true;
                                break;
                            }
                            j--;
                        }
                    }
                    //we've determiend there are better characters before next best or next unskippable, so lets skip this one
                    if(breakFlag)
                        charMap[c].count--;
                    //there are not better characters bef
                    else 
                    {
                        result += c;
                        charMap[c].count -= 1;
                        charMap[c].finalCount -= 1;
                        int numidx = Array.IndexOf(orderedChars, c);
                        orderedChars = orderedChars.Where((val, idx) => idx != numidx).ToArray();
                    }
                    //********************************************************borken part */
                }
                // the only condition left is that we found lexagraphical better character that we don't need any more of
                else
                {
                    charMap[c].count--;
                }
                //if we've completd the string, stop looping
                if(result.Length == strLength)
                    break;
            }      
            return result;
        }
    }
}
