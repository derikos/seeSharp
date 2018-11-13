using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFIrstSeeSharp
{
    namespace DataStructures
    {
        class Node
        {
            Node next = null;
            int data;
            public Node(int d)
            {
                data = d;
            }
            public void Append(int d)
            {
                Node end = new Node(d);
                Node n = this;
                while(n.next != null)
                {
                    n = n.next;
                }
                n = n.next;
            }
        }
        class LinkedList
        {
            Node head;
        }
    }
}
