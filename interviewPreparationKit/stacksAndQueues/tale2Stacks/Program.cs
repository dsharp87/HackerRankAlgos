using System;
using System.Collections.Generic;

namespace tale2Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> fifo = new Stack<int>();
            Stack<int> lifo = new Stack<int>();
            
        }
        public void doThing(int q, int val = 0)
            {
                if(q == 1)
                {
                    while(fifo.Count > 0)
                        lifo.Push(lifo.Pop());
                    lifo.Push(val);
                }
                else
                {
                    while(lifo.Count > 0)
                        fifo.Push(lifo.Pop());
                    if(q == 2)
                        fifo.Pop();
                    else
                        System.Console.WriteLine(fifo.Peek());
                }
            }
        

        
    }
}
