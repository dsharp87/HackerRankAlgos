﻿using System;
using System.Collections.Generic;

namespace birthdayChocolate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static int birthday(List<int> s, int d, int m)
        {   
            int count = 0;
            for(int i = 0; i <= s.Count - m; i++)
            {
                int sum = 0;
                for(int j = i; j < i + m; j++)
                {
                    sum += s[j];

                }
                if(sum == d)
                {
                    count++;
                }
            }
            return count;
        }
        
    }
}
