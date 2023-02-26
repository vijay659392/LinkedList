using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedList
    {
        public Node headNode;
        public Node tailNode;
        public void Add(int data)
        {
            Node node = new Node(data);
            if (this.headNode == null)
            {
                this.headNode = node;
            }
            else
            {
                Node tempNode = headNode;
                while (tempNode.Next != null)
                {
                    tempNode = tempNode.Next;
                }
                tempNode.Next = node;
            }
            Console.WriteLine("{0} inserted into linked list ", node.data);

        }
        public void AddFirst(int data)
        {
            Node newNode = new Node(data);
            newNode.Next = headNode;
            headNode = newNode;
        }
        public void AddLast(int data)
        {
            Node newNode = new Node(data);
            if (headNode == null)
                tailNode = headNode = newNode;
            else
            {
                tailNode.Next = newNode;
                tailNode = newNode;
            }
        }

    }
}
