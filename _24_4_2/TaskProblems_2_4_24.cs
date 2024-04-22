using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject._24_4_2
{
    internal class TaskProblems_2_4_24
    {
        internal class SinglyLinkedList1
        {
            internal class Node
            {
                public string data;
                public Node next;
                public Node (string data)
                {
                    this.data = data;
                }
            }

            Node head;

            public void AddLast(string data)
            {
                Node n = new Node (data);
                if (head  == null)
                {
                    head = n; return;
                }
                Node last = GetLastNode();
                last.next = n;
            }
            public Node GetLastNode()
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                return temp;
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

        }
    }
}
