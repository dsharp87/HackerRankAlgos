using System;

namespace swapNodes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static int[][] swapNodes(int[][] indexes, int[] queries) 
        {
            AlgoTree tr = new AlgoTree(new TNode(1,1));
            int childCount = 2;
            int depth = 1;
            int dCount = 0;
            //interate through the arrays
            // for(int i = 0; i < indexes.Length; i++)
            // {
            //     if
            // }


            return new int[][]{};
        }

        public class AlgoTree
        {
            public TNode root;

            public AlgoTree(TNode r = null)
            {
                this.root = r;
            }

            // public void AddNode(int val, int )
        }

        public class TNode
        {
            public int val;
            public TNode leftNode;
            public TNode rightNode;
            public int depth;

            public TNode(int val, int d, TNode l = null, TNode r = null)
            {
                this.leftNode = l;
                this.rightNode = r;
                this.depth = d;
            }
        }
    }
}
