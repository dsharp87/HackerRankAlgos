using System;

namespace betweenTwoSets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static int getTotalX(int[] a, int[] b)
        {
            int intcount = 0;
            for(int i = findMax(a); i <= findMin(b); i++)
            {
                bool flag = true;
                foreach(int val in a)
                {
                    if(i % val != 0)
                    {
                        flag = false;
                        break;
                    }
                }
                if(flag)
                {
                    foreach(int val in b)
                    {
                        if(val % i != 0)
                        {
                            flag = false;
                            break;
                        }
                    }
                }
                if(flag)
                {
                    intcount++;
                }
            }
            return intcount;
        }

        static int findMax(int[] a)
        {
            int max = a[0];
            foreach(int i in a)
            {
                if(i > max)
                {
                    max = i;
                }
            }
            return max;
        }

        static int findMin(int[] b)
        {
            int min = b[0];
            foreach(int i in b)
            {
                if(i < min)
                {
                    min = i;
                }
            }
            return min;
        }
    }
}
