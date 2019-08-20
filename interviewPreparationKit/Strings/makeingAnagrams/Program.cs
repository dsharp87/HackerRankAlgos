using System;

namespace makeingAnagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string a = "showman";
            string b = "woman";
            int answer = makeAnagram(a,b);
            System.Console.WriteLine(answer);
        }

        static int makeAnagram(string a, string b) {

            //need to inventory each string
            //iterate through each string and count difference between each letter
            int i = 0;
            int result = 0;
            int minLength = a.Length >= b.Length ? b.Length : a.Length;
            int[] aVals = new int[26];
            int[] bVals = new int[26];
            while(i < minLength)
            {
                aVals[char.ToUpper(a[i]) - 65]++;
                bVals[char.ToUpper(b[i]) - 65]++;
                i++;
            }
            if(minLength != b.Length)
            {
                for(int j = i; j < b.Length; j++)
                    bVals[char.ToUpper(b[j]) - 65]++;
            }
            else
            {
                for(int j = i; j < a.Length; j++)
                    aVals[char.ToUpper(a[j]) - 65]++;
            }
            for(int idx = 0; idx < 26; idx++)
            {
                if(aVals[idx] > bVals[idx])
                    result += aVals[idx] - bVals[idx];
                else
                    result += bVals[idx] - aVals[idx];
            }
            return result;
        }
    }
}
