using System;
using System.Collections;
using System.Collections.Generic;

namespace largeRec
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] h = new int[]{1,3,5,7,6,2,4,1};
            long result = largestRectangle(h);
        }

        static long largestRectangle(int[] h) {
            //we need a running count how many buildings in a row are at a specific or higher height
            Stack<int[]> buildings = new Stack<int[]>();
            int i = 0;
            int max = h[i];
            buildings.Push(new int[]{h[i],1});
            i++;
            while(i < h.Length)
            {
                //  right now i'm not sure how to count single width rectangles???
                if(h[i] >= h[i-1])
                    buildings.Push(new int[]{h[i],1});
                else
                {
                    int y = h[i];
                    int x = 1;
                    while(buildings.Count > 0 && buildings.Peek()[0] >= y)
                    {
                        int[] b = buildings.Pop();
                        max = (b[1] + x - 1) * b[0] > max ? (b[1] + x - 1) * b[0] : max;
                        x+= b[1];
                        max = x * y > max ? x * y : max;
                    }
                    buildings.Push(new int[]{h[i],x});
                }
                i++;
            }
            int width = 0;
            while(buildings.Count > 0)
            {
                int[] b = buildings.Pop();
                max = (b[1] + width) * b[0] > max ? (b[1] + width) * b[0] : max;
                width+= b[1];
            }
            return max;
        }

        

    }
}
