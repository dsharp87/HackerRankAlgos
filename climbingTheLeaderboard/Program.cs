using System;
using System.Collections.Generic;

namespace climbingTheLeaderboard
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

         static int[] climbingLeaderboard(int[] scores, int[] alice)
        {
            //want to create a distinct ordered list of scores
            //for every score, check if its in list already
            //if it is, report index position, if not, find where it should be inserted at and insert it, then report index position of that
            
            List<int> leaderboard = distinctScores(scores);
            foreach(int gameScore in alice)
            {
                if(leaderboard.Contains)
            }

            return new int[5];
        }

        static List<int> distinctScores(int[] scores)
        {
            List<int> uniqueScores = new List<int>();
            foreach(int score in scores)
            {
                if(!uniqueScores.Contains(score))
                {
                    uniqueScores.Add(score);
                }
            }
            return uniqueScores;
        }
    }
}
