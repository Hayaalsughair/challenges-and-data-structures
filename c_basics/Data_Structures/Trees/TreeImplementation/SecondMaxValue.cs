using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_basics.Data_Structures.Trees.TreeImplementation
{
    public class SecondMaxValue : BinaryTree
    {
        public int FindSecondMax()
        {
            if (Root == null)
            {
                throw new Exception("Empty Tree");
            }

            int max = 0;
            int secondMax = 0;
            bool foundMax = false;
            bool foundSecondMax = false;

            void Traverse(TNode node)
            {
                if (node == null)
                    return;

                if (!foundMax || node.Value > max)
                {
                    secondMax = max; 
                    max = node.Value;
                    foundMax = true;
                }
                else if (node.Value < max && (!foundSecondMax || node.Value > secondMax))
                {
                    secondMax = node.Value;
                    foundSecondMax = true;
                }

                Traverse(node.Left);
                Traverse(node.Right);
            }

            Traverse(Root);

            if (!foundSecondMax)
            {
                throw new Exception("There is no second maximum value in the tree");
            }

            return secondMax;
        }


    }

}
