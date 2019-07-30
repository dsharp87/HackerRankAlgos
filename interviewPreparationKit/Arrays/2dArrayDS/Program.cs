using System;

namespace _2dArrayDS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[][] test = new int[][]{
                new int []{-9,-9,-9,1,1,1},
                new int []{0,-9,0,4,3,2},
                new int []{-9,-9,-9,1,2,3},
                new int []{0,0,8,6,6,0},
                new int []{0,0,0,-2,0,0},
                new int []{0,0,1,2,4,0}
            };
            int result = hourglassSum(test);
            System.Console.WriteLine(result);
        }

        static int hourglassSum(int[][] arr) 
        {
            int[] sumArr = new int[(arr.Length - 2) * (arr[0].Length - 2)];
            int currMax = -9999;
            int sumIdx = 0;
            for(int i = 0; i < arr.Length - 2; i++)
            {
                for(int j = 0; j < arr[0].Length - 2; j++)
                {
                    int currSum = singleSum(arr, i, j);
                    sumArr[sumIdx] = currSum;
                    if(currSum > currMax)
                        currMax = currSum;
                    sumIdx++;
                }
            }
            return currMax;
        }

        public static int singleSum(int[][] arr, int i, int j)
        {
            int currSum = 0;
            //get top 3 of hourglass
            for(int h = 0; h < 3; h++)
            {
                currSum+= arr[i][j+h];
            }
            //middle 1
            currSum+= arr[i+1][j+1];
            //bottom 3
            for(int h = 0; h < 3; h++)
            {
                currSum+= arr[i+2][j+h];
            }
            return currSum;
        }
    }
}
