using System;

namespace SSL
{
    class Program
    {
        static void Main(string[] args)
        {
            SSL mySSL = new SSL();
            mySSL.AddNode(3);
            SSL mySSL2 = new SSL(new Node(7));
            mySSL2.AddNode(4);
            mySSL2.AddNode(8);
            SSL mySSL3 = new SSL(new Node(7));
            mySSL3.AddNode(4);
            mySSL3.AddNode(8);
            Node node1 = mySSL3.RemoveFirstNodeByVal(4);
            Node node2 = mySSL3.RemoveFirstNodeByVal(7);
            Node node3 = mySSL3.RemoveFirstNodeByVal(12);            
        }

        public class SSL {
            Node head = null;

            public SSL(Node headNode = null)
            {
                head = headNode;
            }

            public void AddNode(int val)
            {
                if(head == null)
                {
                    head = new Node(val);
                }
                else
                {
                    Node current = head;
                    while(current.next != null)
                    {
                        current = current.next;
                    }
                    current.next = new Node(val);
                }
            }

            public Node RemoveFirstNodeByVal(int val)
            {
                if(head == null)
                {
                    return null;
                }
                else if(head.val == val)
                {
                    Node found = head;
                    head = head.next;
                    return found;
                }
                else
                {
                    Node before = head;
                    Node current = before.next;
                    while(current != null)
                    {
                        if(current.val == val)
                        {
                            before.next = current.next;
                            return current;
                        }
                    }
                    return null;
                }
            }

        }

        public class Node {
            public int val;
            public Node next = null;

            public Node(int value, Node nextNode = null)
            {
                next = nextNode;
                val = value;
            }
        }
    }
}
