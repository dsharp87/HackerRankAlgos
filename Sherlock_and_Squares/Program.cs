using System;

namespace Sherlock_and_Squares
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 12;
            int b = 179;
            squares(a,b);
        }

        static int squares(int a, int b) 
        {
            //first lets find the next square
            int nextSquare = 0;
            for(int i = a; i <= b; i++)
            {
                if(Math.Sqrt(i) % 1 == 0)
                {
                    nextSquare = i;
                    break;
                }
            }
            if(nextSquare == 0)
            {
                return 0;
            }
            else
            {
                int squareCount = 0;
                int currentRoot = (int)Math.Sqrt(nextSquare);
                while(nextSquare <= b)
                {
                    squareCount++;
                    nextSquare = nextSquare + 2*currentRoot + 1;
                    currentRoot++;
                }
                return squareCount;   
            }
        }
    }







    //azure sql stack, what can it do asside from just using sql queries

    //application code 

    //be able to merge branches

    //be able to deplploy

    //ravi going back to india soon

    
}