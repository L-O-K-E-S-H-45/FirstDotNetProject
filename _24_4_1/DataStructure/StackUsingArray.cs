using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject._24_4_1.DataStructure
{
    internal class StackUsingArray
    {
        object[] obj;
        int capacity;
        int top;
        public StackUsingArray(int capacity)
        {
            this.capacity = capacity;
            this.obj = new object[capacity];
            top = -1;
        }

        public void Push(object data)
        {
            if (top == capacity - 1)
            {
                Console.WriteLine("Stack if overflow!!!"); return;
            }
            obj[++top] = data;
        }

        public object Pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is underflow!!!"); return null;
            }
            return obj[top--];
        }

        public int Count()
        {
            return top+1;
        }

        public void Display()
        {
            Console.Write("[ ");
            for (int i = 0; i<= top; i++)
                Console.Write(obj[i] + " ");

            Console.WriteLine("]");
        }

        public object Peek()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is underflow!!!"); return null;
            }
            return obj[top];
        }


    }
}
