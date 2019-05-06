using System;

namespace savePrisoner
{
    class Program
    {
        static void Main(string[] args)
        {
            saveThePrisoner(3, 11, 2);
        }

        static int saveThePrisoner(int n, int m, int s) {
            int offset = m%n - 1;
            if(s+offset > n)
            {
                return s + offset - n;
            }
            else
            {
                return s + offset;
            }
        }
    }
}
