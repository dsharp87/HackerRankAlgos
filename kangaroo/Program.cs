using System;

namespace kangaroo
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(jumper(1,2,3,4));
        }

        static string jumper(int x1, int v1, int x2, int v2)
        {
            //invalidate impossibilities
            
            if((x1 < x2 && v1 <= v2) || (x1 > x2 && v1 >= v2))
            {
                return "NO";
            }
            //if possible, do calc
            if(x1 < x2)
            {
                while(x1 < x2)
                {
                    x1 += v1;
                    x2 += v2;
                }
            }
            else if(x2 < x1)
            {
                while(x2 < x1)
                {
                    x1 += v1;
                    x2 += v2;
                }
            }
            if(x1 == x2)
                {
                    return "YES";
                }
            return "NO";
        }
    }
}
