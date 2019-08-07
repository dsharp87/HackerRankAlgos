using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace freqQueryies
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static List<int> freqQuery(int[][] queries) 
        {
            List<int> result = new List<int>();
            Dictionary<int,int> vals = new Dictionary<int, int>();
            
            //iterate through list of queries
            foreach(int[] q in queries)
            {
                if(q[0] == 1)
                {
                    if(vals.ContainsKey(q[1]))
                        vals[q[1]]++;
                    else
                        vals[q[1]] = 1;
                }
                else if(q[0] == 2)
                {
                    if(vals.ContainsKey(q[1]))
                        if(vals[q[1]] <= 1)
                            vals.Remove(q[1]);
                        else
                            vals[q[1]]--;
                }
                else
                {
                    if(vals.ContainsValue(q[1]))
                        result.Add(1);
                    else
                        result.Add(0);
                }
            }
            return result;
        }

        //BOILDER PLATE CODE TIMES OUT, CAN'T SEEM TO MAKE IT SHORTER DESPITE CONVERTING EVERYTHING TO ARRAY
        static void Yolo() 
        {
        int q = Convert.ToInt32(Console.ReadLine().Trim());

        int[][] queries = new int[q][];

        for (int i = 0; i < q; i++) {
            queries[i] = Console.ReadLine().TrimEnd().Split(' ').ToArray().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToArray();
        }

        List<int> ans = freqQuery(queries);


        }



    }


}
