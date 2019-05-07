using System;

namespace AppDel
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "qwerasdf";
            string t = "qwerbsdf";
            appendAndDelete(s,t,6);
        }

        static string appendAndDelete(string s, string t, int k) 
        {
            //can remove last
            //can add to last
            //detect the amount of characters shared starting at front of string
            //have to chop off rest, then add it back
            //odd number of moves only works if you can delete entire string aka moves > (s + t)
            
            //not enough actions to shorten or lengten word
            if(Math.Abs(s.Length - t.Length) > k)
            {
                return "No";
            }
            //action count is large enough to completely erase and rebuild
            if(k >= s.Length + t.Length)
            {
                return "Yes";
            }
            //establish amount of char difference
            int sharedCount = 0;
            for(int i = 0; i < s.Length; i++)
            {
                if(i + 1 <= t.Length)
                {
                    if(s[i] != t[i])
                    {
                        break;
                    }
                sharedCount++;
                }
                else
                {
                    break;
                }
            }
            //establish count of characters to remove
            int removeCount = s.Length - sharedCount;
            //establish count of characters to add back
            int addCount = t.Length - sharedCount;
            //not enough actions to do minum work needed
            if(k < removeCount + addCount)
            {
                return "No";
            }
            //enough actions, but action count left over is odd
            if((k - (removeCount + addCount)) % 2 == 1)
            {
                return "No";
            }
            return "Yes";
        }
    }

    
}
