using c_basics.Data_Structures.Trees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreesTest
{
    public class BinarySearchTreeTest
    {
        [Fact]
        public void Add_ShouldAddNodeToCorrectPosition()
        {
            // Arrange
            var bstTset = new BinarySearchTree();
            bstTset.Add(10);
            bstTset.Add(5);
            bstTset.Add(15);

            var expectedOutput = "5\t10\t15\t";

            // Act
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                bstTset.Print();
                var result = sw.ToString();

                // Assert
                Assert.Equal(expectedOutput, result);
            }
        }

        [Fact]
        public void Contains_ShouldReturnTrueIfNodeExists()
        {
            // Arrange
            var bstTset = new BinarySearchTree();
            bstTset.Add(10);
            bstTset.Add(5);
            bstTset.Add(15);

            // Act
            var exists = bstTset.Contains(15);

            // Assert
            Assert.True(exists);
        }

        [Fact]
        public void Contains_ShouldReturnFalseIfNodeDoesNotExist()
        {
            // Arrange
            var bst = new BinarySearchTree();
            bst.Add(10);
            bst.Add(5);
            bst.Add(15);

            // Act
            var exists = bst.Contains(20);

            // Assert
            Assert.False(exists);
        }

        [Fact]
        public void Remove_ShouldRemoveNodeFromTree()
        {
            // Arrange
            var bst = new BinarySearchTree();
            bst.Add(10);
            bst.Add(5);
            bst.Add(15);
            bst.Add(3);
            bst.Add(7);

            bst.Remove(5);

            var expectedOutput = "3\t7\t10\t15\t"; // In-order traversal

            // Act
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                bst.Print();
                var result = sw.ToString();

                // Assert
                Assert.Equal(expectedOutput, result);
            }
        }
    }
}
