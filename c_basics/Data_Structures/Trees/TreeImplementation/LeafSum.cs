using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace c_basics.Data_Structures.Trees.TreeImplementation
{
    public class LeafSum : BinaryTree
    {
        public int SumOfLeafNodes()
        {
            if (Root == null)
            {
                throw new Exception("Tree is empty");
            }

            return NodeSum(Root);
        }
        private int  NodeSum(TNode node) {
            if (node == null)
                return 0;

            if (node.Left == null && node.Right == null)
            {
                return node.Value;
            }

            int leftSum = NodeSum(node.Left);
            int rightSum = NodeSum(node.Right);

            return leftSum + rightSum;
        }
    }
}
