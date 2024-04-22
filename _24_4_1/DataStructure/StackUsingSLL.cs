using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject._24_4_1.DataStructure
{
    internal class StackUsingSLL
    {
        internal class Node
        {
            public object data;
            public Node prev;
            public Node(object data)
            {
                this.data = data;
            }
        }

        Node top;

        public void Push(object data)
        {
            Node n = new Node(data);
            if (top == null)
            {
                top = n; return;
            }
            n.prev=top;
            top = n;
        }

        public object Pop()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is underflow!!!"); return null;
            }
            object data = top.data;
            top = top.prev;
            return data;
        }

        public int Count()
        {
            int count = 0;
            Node temp = top;
            while (temp != null)
            {
                count++;
                temp = temp.prev;
            }
            return count;
        }

        public void Display()
        {
            Console.Write("[");
            Display(top);
            Console.WriteLine("]");
        }
        private void Display(Node top)
        {
            if (top == null)
                return; 
            if (top.prev != null)
                Display(top.prev);
            Console.Write(top.data + " ");
        }

        public object Peek()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is underflow!!!"); return null;
            }
            return top.data;
        }

    }
}
