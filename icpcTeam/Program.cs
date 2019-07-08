using System;

namespace icpcTeam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        static int[] acmTeam(string[] topic) {

            //nest loops
            //need an arrray of x lenght where x is the number of topics to store count of teams that know that many topics
            //outer loop is for team member number I
            //first inner loop is for team member J, and must start as team member I + 1
            //second inner loop will go through each idex of the two and max++ if either of their values is 1
            int topicCount = topic[0].Length;
            int[] teamCounts = new int[topicCount + 1];
            int currentMax = 0;
            for(int i = 0; i < topic.Length - 1; i++)
            {
                string member1  = topic[i];
                for(int j = i + 1; j < topic.Length; j++)
                {
                    string member2 = topic[j];
                    int currentTeamTopicCount = 0;
                    for(int k = 0; k < topicCount; k++)
                    {
                        if(member1[k] == '1' || member2[k] == '1')
                        {
                            currentTeamTopicCount++;
                        }
                        else if(topicCount - (k + 1) < currentMax - currentTeamTopicCount)
                        {
                            break;
                        }
                    }
                    if(currentTeamTopicCount > currentMax)
                    {
                        currentMax = currentTeamTopicCount;
                    }
                    teamCounts[currentTeamTopicCount]++;
                }
            }
            int[] result = new int[2];
            for(int i = teamCounts.Length - 1; i >= 0; i--)
            {
                if(teamCounts[i] != 0)
                {
                    result[0] = i;
                    result[1] = teamCounts[i];
                    break;

                }
            }
            return result;
        }
    }
}
