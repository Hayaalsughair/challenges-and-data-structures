using c_basics.Data_Structures.Trees;

namespace TreesTest
{
    public class BinaryTreeTest
    {
        [Fact]
        public void PreOrderTraversal_ShouldReturnCorrectOrder()
        {
            // Arrange
            var tree = new BinaryTree();
            tree.Root = new TNode(1);
            tree.Root.Left = new TNode(2);
            tree.Root.Right = new TNode(3);
            tree.Root.Left.Left = new TNode(4);
            tree.Root.Left.Right = new TNode(5);

            var expectedOutput = "1\t2\t4\t5\t3\t";

            // Act
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                tree.PreOrder(tree.Root);
                var result = sw.ToString();

                // Assert
                Assert.Equal(expectedOutput, result);
            }
        }

        [Fact]
        public void InOrderTraversal_ShouldReturnCorrectOrder()
        {
            // Arrange
            var tree = new BinaryTree();
            tree.Root = new TNode(1);
            tree.Root.Left = new TNode(2);
            tree.Root.Right = new TNode(3);
            tree.Root.Left.Left = new TNode(4);
            tree.Root.Left.Right = new TNode(5);

            var expectedOutput = "4\t2\t5\t1\t3\t";

            // Act
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                tree.InOrder(tree.Root);
                var result = sw.ToString();

                // Assert
                Assert.Equal(expectedOutput, result);
            }
        }

        [Fact]
        public void PostOrderTraversal_ShouldReturnCorrectOrder()
        {
            // Arrange
            var tree = new BinaryTree();
            tree.Root = new TNode(1);
            tree.Root.Left = new TNode(2);
            tree.Root.Right = new TNode(3);
            tree.Root.Left.Left = new TNode(4);
            tree.Root.Left.Right = new TNode(5);

            var expectedOutput = "4\t5\t2\t3\t1\t";

            // Act
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                tree.PostOrder(tree.Root);
                var result = sw.ToString();

                // Assert
                Assert.Equal(expectedOutput, result);
            }
        }
    }
}