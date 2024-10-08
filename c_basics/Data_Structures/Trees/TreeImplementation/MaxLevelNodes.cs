using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_basics.Data_Structures.Trees.TreeImplementation
{
    public class MaxLevelNodes:BinaryTree
    {
        public int FindMaxLevelNodes()
        {
            // Edge case: Empty tree
            if (Root == null)
            {
                throw new InvalidOperationException("The tree is empty.");
            }

            List<int> levelCounts = new List<int>();

            TraverseTree(Root, 0, levelCounts);

            // Find the level with the maximum number of nodes
            int maxNodes = 0;
            int maxLevel = 0;
            for (int i = 0; i < levelCounts.Count; i++)
            {
                if (levelCounts[i] > maxNodes)
                {
                    maxNodes = levelCounts[i];
                    maxLevel = i;
                }
            }

            return maxLevel;
        }
        //Helper method 
        private void TraverseTree(TNode node, int level, List<int> levelCounts)
        {
            if (node == null) return;

            // If we're at a new level, add an entry to the list
            if (level == levelCounts.Count)
            {
                levelCounts.Add(0);
            }

            // Increment the count of nodes at this level
            levelCounts[level]++;

            // Recurse for the left and right children
            TraverseTree(node.Left, level + 1, levelCounts);
            TraverseTree(node.Right, level + 1, levelCounts);
        }
    }
}
