using System;

namespace customsort
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] productCodes = new string[]{"3","1","2","3","3","1","1","2","3","2","3","2","3","1","3","1"};
            productCodes = OrderProductsByPriority(productCodes);
        }

        public void OrderProductsByPriority(string[] productCodes)
        {
            int pri3Idx = productCodes.Length - 1;
            int pri1idx = 0;
            for(int i = 0; i < pri3Idx; i++)
            {
                //if its a 1 don't do anything
                if(GetPriority(productCodes[i]) == 1)
                {
                    pri1idx++;
                    continue;
                }
                //if its a 3 we want to efficiently swap it to the end and put a 1 in its place
                else if(GetPriority(productCodes[i]) == 3)
                {
                    //store the 3 you are going to swap
                    string val3 = productCodes[i];
                    //start at farthest towards end where we know there might not be a 3 and go backwards until you find a 1 
                    for(int j = pri3Idx; j > i; j--)
                    {
                        if(GetPriority(productCodes[j]) == 1)
                        {
                            //store the 1 you are going to swap
                            string val1 = productCodes[j];
                            //swap the unkown val into where the 1 was
                            productCodes[j] = productCodes[pri3Idx];
                            //swap the 3 into the end and decrement the 3 idx counter
                            productCodes[pri3Idx] = val3;
                            pri3Idx--;
                            //put the 1 at the front of the array
                            productCodes[i] = val1;
                            pri1idx++;
                            break;
                        }
                    }
                }
                //its a 2 and we swap it with a 1
                else
                {
                    //go look for a 1 forward in array
                    for(int j = i+1; j <= pri3Idx; j++)
                    {
                        if(GetPriority(productCodes[j]) == 1)
                        {
                            //store the 1
                            string val1 = productCodes[j];
                            //swap the vals
                            productCodes[j] = productCodes[i];
                            productCodes[i] = val1;
                            break;
                        }
                    }
                }
            }
            //now to sort the 2's and 3's
            int pri2idx = pri1idx + 1;
            for(int i = pri2idx; i < pri3Idx; i++)
            {
                //if its a 2, leave it
                if(GetPriority(productCodes[i]) == 2)
                {
                    continue;
                }
                //its a 3
                else
                {
                    //start at farthest toward end where we know there might not be a 3 and go backwards until a 2 is located
                    for(int j = pri3Idx; j > i; j--)
                    {
                        //if you find a 3, just move the boundary for 3 down one and keep looking
                        if(GetPriority(productCodes[j]) == 3)
                        {
                            pri3Idx--;
                            continue;
                        }
                        //swap the 2 and the 3, move 3 boundary down 1
                        string val2 = productCodes[j];
                        productCodes[j] = productCodes[i];
                        productCodes[i] = val2;
                        pri3Idx--;
                        break;
                    }
                }
            }
        }

        private static int GetPriority(string productCode)
        {
            return (int)productCode[0] - 48;
        }


    }
}
