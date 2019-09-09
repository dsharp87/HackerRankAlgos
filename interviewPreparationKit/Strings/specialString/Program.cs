using System;

namespace specialString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

        }


        static long superSubCounter(int n, string s)
        {
            //all single characters work
            long res = n;

            for(int i = 0; i < s.Length; i++)
            {
                //save starting character
                char curr = s[i];

                //special character location, -1 for not found yet
                int specialIdx = -1;
                
                //iterate over rest of string
                for(int j = i + 1; j < s.Length; j++)
                {
                    //save current other character
                    char newChar = s[j];

                    //check is aginst initial character
                    if(newChar == curr)
                    {
                        //havn't found special character or special characteris exactly half way between starting idx and current index
                        if(specialIdx == -1 || j - specialIdx == specialIdx - i )
                            res++;
                    }
                    //its not starting character
                    else
                    {
                        //first time finding new character
                        if(specialIdx == -1)
                            specialIdx = j;
                        //we already found a different character, this breaks the possble substring possibility
                        else
                            break;
                    }
                }
            }
            return res;
        }




    

    }
}
