using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_basics.Data_Structures.Trees.TreeImplementation
{
    public class MinimumDepth:BinaryTree
    {
        public int FindMinimumDepth()
        {
            if (Root == null)
            {
                return 0;
            }

           
            List<(TNode, int)> list = new List<(TNode, int)>();
            list.Add((Root, 1));

            while (list.Count > 0)
            {
                var (currentNode, depth) = list[0];
                list.RemoveAt(0);

                // Check if this node is a leaf
                if (currentNode.Left == null && currentNode.Right == null)
                {
                    return depth; 
                }

                if (currentNode.Left != null)
                {
                    list.Add((currentNode.Left, depth + 1));
                }

                if (currentNode.Right != null)
                {
                    list.Add((currentNode.Right, depth + 1));
                }
            }

            return 0;  
        }
    }
}
