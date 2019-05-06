using System;

namespace circular_Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[]{2,5,7,3,4,5};
            int[] queries = new int[]{1,5,4};
            circularArrayRotation2(a, 5, queries);
        }

        static int[] circularArrayRotation(int[] a, int k, int[] queries) {
            int abreiveatedRatations = k % a.Length;
            for(int i = 0; i < abreiveatedRatations; i++)
            {
                a = rotateArrayRight(a);
            }
            int[] result = new int[queries.Length];
            for(int i = 0; i < queries.Length; i++)
            {
                result[i] = a[queries[i]];
            }
            return result;
        }

        static int[] rotateArrayRight(int[] a)
        {
            int last = a[a.Length-1];
            for(int i = a.Length - 1; i > 0; i--)
            {
                a[i] = a[i-1];
            }
            a[0] = last;
            return a;
        }

        static int[] circularArrayRotation2(int[] a, int k, int[] queries) {
        int abreiveatedRatations = k % a.Length;
        a = rotateArrayRightVariableDistance(a, abreiveatedRatations);
        int[] result = new int[queries.Length];
        for(int i = 0; i < queries.Length; i++)
        {
            result[i] = a[queries[i]];
        }
        return result;
        }


        static int[] rotateArrayRightVariableDistance(int[] a, int rotationAmount)
        {
            if(rotationAmount <= a.Length/2)
            {
                //go right
                int[] LastVals = new int[rotationAmount];
                int idxCounter = 0;
                for(int i = a.Length - rotationAmount; i < a.Length; i++)
                {
                    LastVals[idxCounter] = a[i];
                    idxCounter++;
                }
                for(int i = a.Length - 1; i > rotationAmount - 1; i--)
                {
                    a[i] = a[i - rotationAmount];
                }
                for(int i = 0; i < LastVals.Length; i++)
                {
                    a[i] = LastVals[i];
                }
            }
            else
            {
                int leftShift = a.Length - rotationAmount;
                int[] firstVals = new int[leftShift];
                for(int i = 0; i < leftShift; i++)
                {
                    firstVals[i] = a[i];
                }
                for(int i = 0; i < a.Length - leftShift; i++)
                {
                    a[i] = a[i+leftShift];
                }
                int firstValsIdxCounter = 0;
                for(int i = a.Length - leftShift; i < a.Length; i++)
                {
                    a[i] = firstVals[firstValsIdxCounter];
                    firstValsIdxCounter++;
                }
            }
            return a;
        }
    }
}
