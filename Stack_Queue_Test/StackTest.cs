using c_basics.Data_Structures.Stack_Queue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Queue_Test
{
    public class StackTest
    {
        [Fact]
        public void PushingNodeIntoStack()
        {
            // Arrange
            Stack_structure testStack = new Stack_structure();

            // Act
            testStack.Push(10);
            testStack.Push(20);

            // Assert
            Assert.Equal(20, testStack.Peek());
        }
        [Fact]
        public void PopingNodeFromStack()
        {
            // Arrange
            Stack_structure testStack = new Stack_structure();

            // Act
            testStack.Push(10);
            testStack.Push(60);
            testStack.Push(30);

            testStack.Pop();


            // Assert
            Assert.Equal(60, testStack.Peek());
        }
        [Fact]
        public void CheckingIfStackEmpty()
        {
            // Arrange
            Stack_structure testStack = new Stack_structure();

            // Act
            bool isEmpty = testStack.IsEmpty();

            // Assert
            Assert.True(isEmpty);

        }
    }
}
