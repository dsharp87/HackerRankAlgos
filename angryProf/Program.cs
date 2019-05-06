using System;

namespace angryProf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static string angryProfessor(int k, int[] a) {
            int onTime = 0;
            foreach(int arrival in a)
            {
                if(arrival <= 0)
                {
                    onTime++;
                }
            }
            if(onTime >= k)
            {
                return "NO";
            }
            else
            {
                return "YES";
            }
        }
    }
}
