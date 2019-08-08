using System;
using System.Collections.Generic;
using System.Linq;

namespace fraudNotifications
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] vals = new int[]{2,3,4,2,3,6,8,4,5};
            int[] vals2 = new int[]{10,20,30,40,50};
            int[] vals3 = new int[]{1,2,3,4,4};
            // int result = activityNotifications(vals3, 4);
            int res2 = AlternativeSolution(vals, 5);
        }

        static int activityNotifications(int[] expenditure, int d) 
        {
            
            if(expenditure.Length <= d)
                return 0;
            // Queue<int> trail = new Queue<int>();
            // for(int i = 0; i < d; i++)
            //     trail.Enqueue(expenditure[i]);
            
            //storage for result
            int noteCount = 0;

            //this will be array most recent transaction values
            //we load it with the initial d values
            int[] t = new int[d];
            for(int i = 0; i < d; i++)
                t[i] = expenditure[i];

            //this will keep track of which index we need to replace in the next transaction trail
            int idx = 0;

            //go thourgh the remaining values
            for(int i = 1; i <= expenditure.Length - d; i++)
            {
                //clone the array holding the trail
                int[] tSorted = (int[])t.Clone();

                //sort the cloned array
                tSorted = QSort(tSorted, 0, d-1);
                double mid;
                
                //find the median value based on odd/even lenght of trail
                if(d % 2 == 1)
                    mid = tSorted[d/2];
                else
                    mid = ((double)tSorted[d/2 - 1] + (double)tSorted[d/2])/2;
                
                //check current val against mid, increasing notification count if so
                if(expenditure[d+i - 1] >= 2*mid)
                    noteCount++;

                //replace the oldest tail value, using idx%d to know which value is currently the oldest
                t[idx%d] = expenditure[d+i - 1];
                idx++;
            }
            return noteCount;  
        }

        public static int[] QSort(int[] arr, int low, int high)
        {   
            if(low < high)
            {
                int p = partition(arr, low, high);
                QSort(arr, low, p - 1);
                QSort(arr, p + 1, high);
            }
            return arr;
        }

        public static int partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int s = low - 1;
            for(int i = low; i < high; i++)
            {
                if(arr[i] <= pivot)
                {
                    s++;
                    int temp = arr[s];
                    arr[s] = arr[i];
                    arr[i] = temp;
                }
            }
            arr[high] = arr[s+1];
            arr[s+1] = pivot;
            return s+1;
        }

        public static int AlternativeSolution(int[] expenditure, int d)
        {
            //hold result
            int notifications = 0;

            //trail array, copy part of expendature into it
            var arr = new int[d];
            Array.Copy(expenditure, arr, d);

            //sorts it
            Array.Sort(arr);
            for (int i = d; i < expenditure.Length; i++)
            {   
                //handles both cases of odd and even lenght of d, as the *2 aspect means you are adding  either the mid value twice, or the -1/+1 value
                if (expenditure[i] >= arr[d / 2] + arr[(d - 1) / 2])
                {
                    notifications++;
                }

            //find index oldest value in sorted array    
            int index = Array.BinarySearch(arr, expenditure[i - d]);

            //copy remaning right side off sorted array onto index -> length - 1
            Array.Copy(arr, index + 1, arr, index, d - index - 1);

            index = Array.BinarySearch(arr, 0, d - 1, expenditure[i]);
            index = index >= 0 ? index : ~index;
            Array.Copy(arr, index, arr, index+1, d - index - 1);
            arr[index] = expenditure[i];
            }
            return notifications;
        }
    }
}
