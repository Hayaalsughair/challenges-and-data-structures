using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace c_basics.Data_Structures.Trees
{
    public class BinarySearchTree : BinaryTree
    {
        public void Add(int data)
        {
            Root = Add(Root, data); 
        }

        private TNode Add(TNode root, int data)
        {
            if (root == null)
            {
                return new TNode(data);
            }

            if (data < root.Value)
            {
                root.Left = Add(root.Left, data);
            }
            else if (data > root.Value)
            {
                root.Right = Add(root.Right, data);
            }
            return root;
        }

        public void Remove(int data)
        {
            Root = Remove(Root, data);
        }

        private TNode Remove(TNode node, int data)
        {
            if (node == null) return node;

            if (data < node.Value)
                node.Left = Remove(node.Left, data);
            else if (data > node.Value)
                node.Right = Remove(node.Right, data);
            else
            {
                if (node.Left == null)
                    return node.Right;
                else if (node.Right == null)
                    return node.Left;

                node.Value = MinValue(node.Right);

                node.Right = Remove(node.Right, node.Value);
            }

            return node;
        }

        public bool Contains(int value)
        {
            TNode current = Root;
            while (current != null)
            {
                if (value > current.Value)
                {
                    current = current.Right;
                }
                else if (value < current.Value)
                {
                    current = current.Left;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }

        private int MinValue(TNode node)
        {
            int minValue = node.Value;
            while (node.Left != null)
            {
                minValue = node.Left.Value;
                node = node.Left;
            }
            return minValue;
        }
    }
}
