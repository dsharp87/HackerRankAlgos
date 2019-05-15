using System;

namespace lowestNumberRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = "4205123";
            int n = 4;
            string result = GenerateLowestNumber(number, n);
            System.Console.WriteLine(result);
        }

        public static string GenerateLowestNumber2(string number, int n)
        {
            if(n == 0)
            {
                return "";
            }
            else
            {
                int lowest = (int)number[0] - 48;
                int finalStrLength = number.Length - n;
                int idxOfLowest = 0;
                for(int i = 1; i <= number.Length - finalStrLength; i++)
                {
                    if((int)number[i] - 48 < lowest)
                    {
                        lowest = (int)number[i] - 48;
                        idxOfLowest = i;
                    }
                }
                string firstChar = "" + number[idxOfLowest];
                string newNumber = "";
                int removedCount = idxOfLowest;
                n -= removedCount;
                if( n > 0)
                {
                    for(int j = idxOfLowest + 1; j < number.Length; j++)
                    {
                        newNumber += number[j];
                    }
                }            
                return firstChar + GenerateLowestNumber2(newNumber, n);
            }
        }

        public static string GenerateLowestNumber(string number, int n)
        {
            int finalStrLength = number.Length - n;
            string result = "";
            int idxToStartAt = 0;
            while(result.Length != finalStrLength)
            {
                int currentLowest = (int)number[idxToStartAt] - 48;
                int idxOfCurrentLowest = idxToStartAt;
                for(int i = idxToStartAt + 1; i <= n + result.Length; i++)
                {
                    if((int)number[i] - 48 < currentLowest)
                    {
                        currentLowest = (int)number[i] - 48;
                        idxOfCurrentLowest = i;   
                    }
                    if(currentLowest == 0)
                    {
                        break;
                    }
                }
                idxToStartAt = idxOfCurrentLowest + 1;
                result += number[idxOfCurrentLowest];
            }
            return result;
        }
    }
}
