using System;

namespace viralAdds
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

            static int viralAdvertising(int n) {
                int totallikes = 2;
                int shared = 6;
                for(int i = 0; i < n - 1; i++)
                {
                    totallikes += shared/2;
                    shared = (shared/2)*3;
                }
                return totallikes;
            }
    }
}
