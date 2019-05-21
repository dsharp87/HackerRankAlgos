using System;
using System.Collections.Generic;
using System.Linq;

namespace cutSticks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] sticks = new int[]{5,4,4,2,2,8};
            int[] result = cutTheSticks(sticks);
            System.Console.WriteLine("done");
        }

            static int[] cutTheSticks(int[] arr) 
            {
                List<int> arrToLst = arr.ToList();
                List<int> stickCount = new List<int>{};
                while(arrToLst.Count > 0)
                {
                    stickCount.Add(arrToLst.Count);
                    int cutAmount = arrToLst.Min();
                    for(int i = 0; i < arrToLst.Count; i++)
                    {
                        if(arrToLst[i] - cutAmount <= 0)
                        {
                            arrToLst.RemoveAt(i);
                            i--;
                        }
                        else
                        {
                            arrToLst[i] -= cutAmount;
                        }
                    }
                }
                int[] result = stickCount.ToArray();
                return result;
            }

    }
}
