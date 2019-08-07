using System;
using System.Collections.Generic;

namespace countTrips
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<long> vals = new List<long>{1,5,5,25,125};
            long result = countTriplets(vals, 5);
        }

        //BRUTE FORCE METHOD
        static long countTriplets2(List<long> arr, long r) 
        {
            //im thinking of a tripple nested loop
            //iterate through each value (n - 2), using it as the base
            //for each base value, iterate through the remaining (n - 1)
            //if the secondary value is the geometric progression, trigger third loop,
            //if the 3rd value is a geometric progress, count ++ and continue looking

            int amount = 0;
            for(int i = 0; i < arr.Count - 2; i++)
            {
                long val1 = arr[i];
                for(int j = i + 1; j < arr.Count - 1; j++)
                {
                   long val2 = arr[j];
                   if(val1 * r == val2)
                   {
                       for(int k = j + 1; k < arr.Count; k++)
                       {
                            long val3 = arr[k];
                           if(val2 * r == val3)
                            amount++;
                       }
                   } 
                }
            }
            return amount;
        }

        //Hashmap method ELEGANT METHOD
        //looked up soloution in discussion area
        static long countTriplets(List<long> arr, long r) 
        {
            //this will hold <Value that would be 2nd in chain, number of values we found earlier in array that would be compatible as first (1/3 complete)>
            var mp2 = new System.Collections.Generic.Dictionary<long,long>();

            //this will hold <Value that would be 3rd in chain, number of (2/3) complete combinations we found earlier in array that would be comppleted by current value>
            var mp3 = new System.Collections.Generic.Dictionary<long,long>();
            long res = 0;
            foreach (long val in arr)
            {
                //check to see we've encountered (2/3) sets that would be compatible with this value as 3rd
                if (mp3.ContainsKey(val))
                    //if so, we want to increase total by this count of (2/3) sets
                    res += mp3[val];

                //check to see if we've encountered values previously that would use current val as their 2nd (2/3) value in the chain
                //this is represented by existence in the (2/3) dictionary
                if (mp2.ContainsKey(val))
                    //if we've already added the geomeetric progression of current val to (3/3) dictionary
                    //we need to increase it by the current possible (2/3) chains that existed when this value was encountered
                    if (mp3.ContainsKey(val*r))
                        mp3[val*r] += mp2[val];

                    //simlar to (2/3) dictionary, we need to add the geometric progression to the (3/3) dictionary
                    //as we could have encountered the current (1/3) value mutliple times, we must add the current (2/3) value into the new (3/3) dictionary
                    //this will mean the next time a val of currentVall * r is encountered, 
                    //we will know there are this many possible (2/3) chains before it in the array
                    else
                        mp3[val*r] = mp2[val];
                
                //check if current val's geometric progression exists in the (2/3) dictionary,
                //if it does, we need to increment so that we know there are n+1 suitible (1/3) values the next time we encounter its geometric progression
                if (mp2.ContainsKey(val*r))
                    mp2[val*r]++;

                //first time we encountered this value, add its multiple to the (2/3) dictionary with a count of 1
                //this means that if we encounter a value in the future that is the geometic progression of this value, 
                //we know that there was one value earlier in the array that would serve as (1/3) in chain
                else
                    mp2[val*r] = 1;
            }
        return res;
    }


    }
}
