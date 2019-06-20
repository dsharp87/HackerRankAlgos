using System;

namespace queenAttack2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 6;
            int k = 16;
            int r = 3;
            int c = 3;
            int[][] obstablces = new int[][]
            {
                //farther
                new int[]{6,3},
                new int[]{6,6},
                new int[]{3,6},
                new int[]{1,5},
                new int[]{1,3},
                new int[]{1,1},
                new int[]{3,1},
                new int[]{5,1},
                //closer
                new int[]{5,3},
                new int[]{5,5},
                new int[]{3,5},
                new int[]{2,4},
                new int[]{2,3},
                new int[]{2,2},
                new int[]{3,2},
                new int[]{4,2}
            };
            int final = queensAttack(n,k,r,c,obstablces);
            System.Console.WriteLine(final);
        }

            static int queensAttack(int n, int k, int r, int c, int[][] obstacles) 
            {

                //n = dimension of board
                //k = count of obsticles
                //r = queen row pos
                //c = queen column pos
                //obstablces - each sub aray is pos r/c

                //hold max number of spaces in each direction queen can go
                //have check to ditermine if obsticle is in path
                //check should be nested ifs to determine which direction obsticle is 

                //idx 0 is top, going clockwise
                int[] maxMoveArr = new int[8];
                maxMoveArr[0] = n-r;
                maxMoveArr[1] = Math.Min(n-r, n-c);
                maxMoveArr[2] = n-c;
                maxMoveArr[3] = Math.Min(r-1, n-c);
                maxMoveArr[4] = r-1;
                maxMoveArr[5] = Math.Min(r-1, c-1);
                maxMoveArr[6] = c-1;
                maxMoveArr[7] = Math.Min(n-r, c-1);
                foreach(int[] rc in obstacles)
                {
                    int row = rc[0];
                    int col = rc[1];
                    //check for up
                    if(row > r)
                    {
                        //directly above
                        if(col - c == 0)
                        {
                            if(row - r - 1 < maxMoveArr[0])
                            {
                                maxMoveArr[0] = row - r - 1;
                            }
                        }
                        //check for diagonal left, difference between rc and obsticle rc must be same
                        else if(col < c && (c - col == row - r)) 
                        {
                            if((row - r - 1) < maxMoveArr[7])
                            {
                                maxMoveArr[7] = row - r - 1;
                            }
                        }
                        //check for diagonal right
                        else if(col > c && (col - c == row - r))
                        {
                            if(row - r - 1 < maxMoveArr[1])
                            {
                                maxMoveArr[1] = row - r - 1;
                            }
                        }
                        //its above but not diagonal, so stop looking
                        else
                        {
                            continue;
                        }
                    }
                    //check same row
                    else if(row == r)
                    {
                        //to the left of queen
                        if(col < c)
                        {
                            if(c - col - 1 < maxMoveArr[6])
                            {
                                maxMoveArr[6] = c - col - 1;
                            }
                        }
                        //to the right
                        else
                        {
                            if(col - c - 1 < maxMoveArr[2])
                            {
                                maxMoveArr[2] = col - c - 1;
                            }
                        }
                    }
                    //if not above, and not at same row, it must be below
                    else
                    {
                        //directly below
                        if(col == c)
                        {
                            if(r - row - 1 < maxMoveArr[4])
                            {
                                maxMoveArr[4] = r - row - 1;
                            }
                        }
                        //diagonally right
                        else if(col > c && (col - c == r - row))
                        {
                            if(r - row - 1 < maxMoveArr[3])
                            {
                                maxMoveArr[3] = r - row - 1;
                            }
                        }
                        //diagonally left
                        else if(col < c && (c - col == r - row))
                        {
                            if(r - row - 1 < maxMoveArr[5])
                            {
                                maxMoveArr[5] = r - row - 1;
                            }
                        }
                    }
                }
                //sum final count
                int totalMoves = 0;
                foreach(int val in maxMoveArr)
                {
                    totalMoves += val;
                }
                return totalMoves;
            }

    }
}
