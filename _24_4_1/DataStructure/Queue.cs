using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject._24_4_1.DataStructure
{
    internal class Queue
    {
        internal class Node
        {
            public object data;
            public Node next;
            public Node(object data)
            {
                this.data = data;
            }
        }

        Node head;

        public void Push(object data)
        {
            Node n = new Node(data);
            if (head ==  null)
            {
                head = n; return;
            }
            Node last = GetLastNode();
            last.next = n;
        }
        private Node GetLastNode()
        {
            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }

        public object Poll()
        {
            if (head == null)
            {
                Console.WriteLine("Queue is empty!!!"); return null;
            }
            object data = head.data;
            head = head.next;
            return data;
        }

        public void Display()
        {
            Node temp = head;
            Console.Write("[ ");
            while (temp != null) 
            { 
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine("]");
        }

        public object Peek()
        {
            if (head == null)
            {
                Console.WriteLine("Queue is empty!!!"); return null;
            }
            return head.data;
        }

    }
}
