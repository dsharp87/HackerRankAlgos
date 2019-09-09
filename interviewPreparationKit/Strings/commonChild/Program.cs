using System;
using System.Collections.Generic;

namespace commonChild
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "WEWOUCUIDGCGTRMEZEPXZFEJWISRSBBSYXAYDFEJJDLEBVHHKS";
            string s2 = "FDAGCXGKCTKWNECHMRXZWMLRYUCOCZHJRRJBOAJOQJZZVUYXIC";
            commonChild(s1,s2);
            string s3 = "HNHA";
            string s4 = "NHAAAA";

        }

        static int commonChild(string s1, string s2)
        {
            //dynamic programming, need a grid to reference common sub seququece at given position in the two strings
            int[,] grid = new int[s1.Length+1,s2.Length+1];
            
            //populate the first column/row of grid with 0's as the evaluation is with 0 characters from one string, long is the common string given 0 - X character from other string
            for(int i = 0; i< s1.Length; i++)
            {
                grid[i,0] = 0;
                grid[0,i] = 0;
            }

            //go through one string
            for(int i = 0; i < s1.Length; i++)
            {
                //for each character go through second string
                for(int j = 0; j < s1.Length; j++)
                {
                    //if the same character is found at this combination
                    //its the max of the 1 character backwards in each string + 1
                    if(s1[i] == s2[j])
                        grid[i+1,j+1] = grid[i,j] + 1;
                    //otherwise, its the same as whatever the max is between either 1 less charcter ins s1, or 1 less in s2
                    else
                    {
                        grid[i+1,j+1] = grid[i+1,j] > grid[i,j+1] ? grid[i+1,j] : grid[i,j+1];
                    }
                }
            }
            return grid[s1.Length,s1.Length];
        }
    }
}


