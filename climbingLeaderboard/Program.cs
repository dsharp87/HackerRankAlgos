using System;
using System.Collections.Generic;
using System.Linq;

namespace climbingLeaderboard
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static int[] climbingLeaderboard(int[] scores, int[] alice) {
            List<int> uniqueScores = new List<int>();
            foreach(int score in scores)
            {
                if(!uniqueScores.Contains(score))
                {
                    uniqueScores.Add(score);
                }
            }
            List<int> placeList = new List<int>();
            foreach(int score in alice)
            {
                uniqueScores = updateLeaderboard(uniqueScores, score);
                placeList.Add(recordPlace(uniqueScores, score));
            }
            return placeList.ToArray();
        }

        public static List<int> updateLeaderboard (List<int> scores, int score)
        {
            if(scores.Contains(score))
            {
                return scores;
            }
            else
            {
                for(int i = 0; i < scores.Count; i++)
                {
                    if(score > scores[i])
                    {
                        scores.Insert(i, score);
                        return scores;
                    }
                }
                scores.Add(score);
                return scores;
            }
        }

        public static int recordPlace(List<int> scores, int score)
        {
            return scores.IndexOf(score) + 1;
        }

    }
}
