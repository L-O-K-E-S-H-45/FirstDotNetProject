using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject._24_4_1.DataStructure
{
    internal class BinarySeachTree
    {
        internal class Node
        {
            public int value;
            public Node left;
            public Node right;
            internal Node(int value)
            {
                this.value = value;
            }
        }

        Node root;

        public void Insert(int x)
        {
            Node newNode = new Node(x);
            if (root == null)
            {
                root = newNode; return;
            }
            Node current = root;
            Node parent = current;
            while (true)
            {
                if (x == parent.value) return;
                else if (x < parent.value)
                {
                    if (parent.left == null)
                    {
                        parent.left = newNode; return;
                    }
                    parent = parent.left;
                } 
                else if (x > parent.value)
                {
                    if (parent.right == null)
                    {
                        parent.right = newNode; return;
                    }
                    parent = parent.right;
                }

            }
        }

        public void Display()
        {
            Console.Write("[ ");
            DisplayByInorderTraversal(root);
            Console.WriteLine("]");
        }
        private void DisplayByInorderTraversal(Node node)
        {
            if (node == null) return;
            DisplayByInorderTraversal(node.left);
            Console.Write(node.value + " ");
            DisplayByInorderTraversal(node.right);
        }
    }
}
