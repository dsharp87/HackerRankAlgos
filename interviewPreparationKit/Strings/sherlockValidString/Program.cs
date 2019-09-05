using System;
using System.Collections.Generic;

namespace sherlockValidString
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "ibfdgaeadiaefgbhbdghhhbgdfgeiccbiehhfcggchgghadhdhagfbahhddgghbdehidbibaeaagaeeigffcebfbaieggabcfbiiedcabfihchdfabifahcbhagccbdfifhghcadfiadeeaheeddddiecaicbgigccageicehfdhdgafaddhffadigfhhcaedcedecafeacbdacgfgfeeibgaiffdehigebhhehiaahfidibccdcdagifgaihacihadecgifihbebffebdfbchbgigeccahgihbcbcaggebaaafgfedbfgagfediddghdgbgehhhifhgcedechahidcbchebheihaadbbbiaiccededchdagfhccfdefigfibifabeiaccghcegfbcghaefifbachebaacbhbfgfddeceababbacgffbagidebeadfihaefefegbghgddbbgddeehgfbhafbccidebgehifafgbghafacgfdccgifdcbbbidfifhdaibgigebigaedeaaiadegfefbhacgddhchgcbgcaeaieiegiffchbgbebgbehbbfcebciiagacaiechdigbgbghefcahgbhfibhedaeeiffebdiabcifgccdefabccdghehfibfiifdaicfedagahhdcbhbicdgibgcedieihcichadgchgbdcdagaihebbabhibcihicadgadfcihdheefbhffiageddhgahaidfdhhdbgciiaciegchiiebfbcbhaeagccfhbfhaddagnfieihghfbaggiffbbfbecgaiiidccdceadbbdfgigibgcgchafccdchgifdeieicbaididhfcfdedbhaadedfageigfdehgcdaecaebebebfcieaecfagfdieaefdiedbcadchabhebgehiidfcgahcdhcdhgchhiiheffiifeegcfdgbdeffhgeghdfhbfbifgidcafbfcd";
            System.Console.WriteLine(isValid(s));
        }

        static string isValid(string s) {
            //make a dictionary for letters
            //once dictionary is complete, we need to go through it
            //store primary value,
            //all the rest of the values either need to be the same or all higher by one or all lower by one
            //if any value is +/- > 1, then return no
            //if a value is different than the inital one store that different
            
            Dictionary<char,int> chars = new Dictionary<char, int>();
            foreach(char c in s)
            {
                if(chars.ContainsKey(c))
                    chars[c]++;
                else
                    chars[c] = 1;
            }
            int primary = 0;
            int second = 0;
            bool primaryFlag = false;
            bool singleSingle = false;
            foreach(KeyValuePair<char,int> val in chars)
            {
                //this should only trigger first time
                if(primary == 0)
                    primary = val.Value;
                //always check for broken value
                else if(Math.Abs(val.Value - primary) > 1)
                {
                    if(!singleSingle && val.Value == 1)
                        singleSingle = true;
                    else
                        return "NO";
                }
                //same value we've encountered so for, or the value we know its safe to encounter
                else if(val.Value == primary)
                {
                    //if we've not found the repeating number yet, we have not so flag it
                    if(!primaryFlag)
                        primaryFlag = true;
                }
                //we've encountered a different value for the first time and its not a broken value, and we havn't established the repeating value yet
                else if(!primaryFlag)
                {
                    //don't have second value yet, assign it
                    if(second == 0)
                        second = val.Value;
                    //we have second value, and its now the primary value, so swap the two and set the flag
                    else if(second == val.Value)
                    {
                        second = primary;
                        primary = val.Value;
                        primaryFlag = true;
                    }
                }
                else
                {
                    if(second == 0)
                        second = val.Value;
                    else
                        return "NO";
                }
            }
            return "YES";
        }
    }
}
