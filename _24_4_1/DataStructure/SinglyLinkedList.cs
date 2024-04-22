using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject._24_4_1.DataStructure
{
    internal class SinglyLinkedList
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
        
        public void AddFirst(object data)
        {
            Node n = new Node(data);
            if (head == null)
            {
                head = n;   return;
            }
            n.next = head;
            head = n;
        }

        public Node GetLastNode()
        {
            Node curr = head;
            while (curr.next != null)
                curr = curr.next;
            return curr;
        }
        public void AddLast(object data)
        {
            Node n = new Node(data);
            if (head == null)
            {
                head = n;   return;
            }
            Node last = GetLastNode();
            last.next = n;
        }

        public void Add(int index, object data)
        {
            int ind = index;
            if (index <0 || index > Count())
            {
                Console.WriteLine($"{ind} Invalid index!!!"); return;
            }
            if (index == 0)
            {
                AddFirst(data); return;
            }
            
            Node curr = head;
            while (curr != null && index > 1)
            {
                index--;
                curr = curr.next;
            }
            if (curr != null)
            {
                Node n = new Node(data);
                n.next = curr.next;
                curr.next = n;
            }
            else
                Console.WriteLine($"{ind} Index not in the range!!!");
        }

        public int Count()
        {
            int count = 0;
            Node temp = head;
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            return count;
        }

        public void Display()
        {
            if(head == null)
            {
                Console.WriteLine("List is empty"); return;
            }
            Node temp = head;
            Console.Write("[ ");
            do {
                Console.Write(temp.data + " ");
                temp = temp.next; 
            } while (temp != null);
            Console.WriteLine("]");
        }

        public object DeleteFirst()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty"); return null;
            }
            object data = head.data;
            head = head.next;
            return data;
        }

        public object DeleteLast()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty"); return null;
            }
            Node curr = head;
            Node prev = null;
            while (curr.next != null)
            {
                prev = curr;
                curr = curr.next;
            }
            if (prev != null)
                prev.next = null;
            else 
                head = null;
            return curr.data;
        }

        public object Delete(int index)
        {
            int ind = index;
            if (index < 0 || index >= Count())
            {
                Console.WriteLine($"{ind} Invalid index!!!"); return null;
            }
            if (index == 0)
                return DeleteFirst();
            Node curr = head;
            Node prev = null;
            while (curr != null && index > 0)
            {
                index--;
                prev = curr;
                curr = curr.next;
            }
            if (curr != null)
            {
                prev.next = curr.next;
                return curr.data;
            }
            else
            {
                Console.WriteLine($"{ind} Index not in rannge!!!"); return null;
            }
        }

        public void ReverseSLL()
        {
            ReverseSLL(head);
        }
        private void ReverseSLL(Node start)
        {
            if (start == null || start.next == null)
            {
                head = start; return;
            }
            ReverseSLL(start.next);
            start.next.next = start;
            start.next = null;
        }

        public void ReverseSLL2()
        {
            Node prev = null;
            Node curr = head;
            Node next = null;
            while (curr != null)
            {
                next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }
            head = prev;
        }


    }
}
