using System;
using System.Collections.Generic;


namespace migratoryBirds
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> birds = new List<int>{1,4,4,4,5,3};
            System.Console.WriteLine(birdSightings2(birds));
        }


        //MUCH SIMPLER SOLUTION ONCE I NOTICED THAT ONLY 1-5 ARE ALLOWED IN BIRD TYPE LIST
        static int birdSightings2(List<int> arr)
        {
            List<int> counts = new List<int>{0,0,0,0,0};
            foreach(int bird in arr)
            {
                counts[bird-1]++;
            }
            int birdnum = 5;
            int max = counts[4];
            for(int bird = 3; bird >= 0; bird--)
            {
                if(counts[bird] >= max)
                {
                    max = counts[bird];
                    birdnum = bird + 1;
                }
            }
            return birdnum;
        }


        //THIS IS A MUCH MUCH MORE COMPLEX SOLUTION IF BIRD TYPE IS OF UNKNOWN VARIETY (INSTEAD OF JUST 5)
        //IT ALSO FAILS 2 OF THE TESTCASES BUT I DON'T NOW WHY
        // static int birdSightings(List<int> arr)
        // {
        //     //return the smallest number that occurs the most in the array
        //     //storage array of unique numbers
        //     //storage array2 of counts
        //     //loopthrough checking if its unique, if it is, add it to array1, then count it
            
        //     //unique numbers
        //     List<int> nums = new List<int>{};

        //     //count of each unique number
        //     List<int> counts = new List<int>{};

        //     //loop through entire array once
        //     for(int i = 0; i < arr.Count; i++)
        //     {
        //         //if we havn't seen this number yet
        //         if(!nums.Contains(arr[i]))
        //         {
        //             //add it to unique num list
        //             nums.Add(arr[i]);
        //             //estabish starting count of 1
        //             int count = 1;
        //             //loop through remaining area of list, starting at index after where number was found
        //             for(int j = i+1; j < arr.Count; j++)
        //             {
        //                 //if this number matches current number at index i, increase its count
        //                 if(arr[j] == arr[i])
        //                 {
        //                     count++;
        //                 }
        //             }
        //             //add the count of this number to the count array
        //             counts.Add(count);
        //         }
        //     }
        //     //get list of index positions in nums array that have max counts associated with them
        //     List<int> maxindexes = findAllMax(counts);
        //     //assume min number is the first index positions found in index
        //     int minNumAtIndex = arr[maxindexes[0]];
        //     //loop throught rest of indexes list
        //     for(int index = 1; index < maxindexes.Count; index++)
        //     {
        //         //if the number at this index is smaller, replace min
        //         if(arr[maxindexes[index]] < minNumAtIndex)
        //         {
        //             minNumAtIndex = arr[maxindexes[index]];
        //         }
        //     }
        //     return minNumAtIndex;
        // }

        // static List<int> findAllMax(List<int> counts)
        // {
        //     //this is going to store the index locations in the nums list that have max counts
        //     List<int> indexes = new List<int>{};
        //     //assume first count is max
        //     int max = counts[0];
        //     //add index pos 0 to indexes list
        //     indexes.Add(0);
        //     //loop through rest of counts list
        //     for(int i = 1; i < counts.Count; i++)
        //     {
        //         //check if its same max count, then add to indexes if so
        //         if(counts[i] == max)
        //         {
        //             indexes.Add(i);
        //         }
        //         //check if we found a new max count
        //         else if(counts[i] > max)
        //         {
        //             //if so, reset max to this new number, and destroy/rebuild indexlist from scratch
        //             max = counts[i];
        //             indexes.Clear();
        //             indexes.Add(i);
        //         }
        //     }
        //     return indexes;
        // }




    }
}
