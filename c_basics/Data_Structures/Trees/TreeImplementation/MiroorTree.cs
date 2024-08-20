namespace c_basics.Data_Structures.Trees.TreeImplementation
{
    public class MiroorTree : BinarySearchTree
    {
        public void MirrorTree()
        {
            Mirror(Root);
        }

        private void Mirror(TNode node)
        {
            if (node == null)
            {
                return;
            }

            // Swaping
            TNode temp = node.Left;
            node.Left = node.Right;
            node.Right = temp;

            Mirror(node.Left);
            Mirror(node.Right);
        }

        
    }
}
