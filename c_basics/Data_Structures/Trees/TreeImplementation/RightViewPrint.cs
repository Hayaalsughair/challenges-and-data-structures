using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_basics.Data_Structures.Trees.TreeImplementation
{
    public class RightViewPrint : BinaryTree
    {
        public void PrintRightView()
        {
            int maxLevel = 0;
            RightPrinterHelper(Root, 1,ref maxLevel);
            Console.WriteLine();
        }

        private void RightPrinterHelper(TNode node, int level, ref int maxLevel)
        {
            if (node == null)
            {
                return;
            }

            if (maxLevel < level)
            {
                Console.Write($"{node.Value} ");
                maxLevel = level;
            }

            RightPrinterHelper(node.Right, level + 1,ref maxLevel);
            RightPrinterHelper(node.Left, level + 1,ref maxLevel);
        }
    }

}
