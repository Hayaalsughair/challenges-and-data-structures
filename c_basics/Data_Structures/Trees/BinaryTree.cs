using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_basics.Data_Structures.Trees
{
    public class BinaryTree 
    {
        public TNode Root { get; set; }

        public BinaryTree()
        {
            Root = null;
        }

        public void PreOrder(TNode node)
        {
            if (node != null)
            {
                Console.Write($"{node.Value}\t");
                PreOrder(node.Left);
                PreOrder(node.Right);
            }
        }
        public void InOrder(TNode node)
        {
            if (node != null)
            {
                InOrder(node.Left);
                Console.Write($"{node.Value}\t");
                InOrder(node.Right);
            }
        }
        public void PostOrder(TNode node)
        {
            if (node != null)
            {
                PostOrder(node.Left);
                PostOrder(node.Right);
                Console.Write($"{node.Value}\t");
            }
        }
        public void Print()
        {
            InOrder(Root);
            Console.WriteLine();
        }
    }
}
