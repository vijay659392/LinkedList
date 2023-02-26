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

    }
}
