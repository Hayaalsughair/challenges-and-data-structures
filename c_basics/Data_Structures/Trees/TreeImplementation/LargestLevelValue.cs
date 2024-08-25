using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_basics.Data_Structures.Trees.TreeImplementation
{
    public class LargestLevelValue : BinaryTree
    {
        private void Helper(List<int> largestValue,TNode root, int level)
                   
        {
            if (root == null)
                return;

            if (level == largestValue.Count)
            {
                largestValue.Add(root.Value);
            }
            else
            {
                largestValue[level] = Math.Max(largestValue[level], root.Value);

            }

            Helper(largestValue, root.Left, level + 1);
            Helper(largestValue, root.Right, level + 1);
        }
        public  List<int> LargestValueEachLevel(TNode root)
        {

            List<int> values = new List<int>();
            if (root != null)
            {
                Helper(values, root, 0);
            }
            return values;
        }
    }
}
