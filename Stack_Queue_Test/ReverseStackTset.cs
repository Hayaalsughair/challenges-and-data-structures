using c_basics.Data_Structures.Stack_Queue.ReverseStackUsingQueue;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Queue_Test
{
    public class ReverseStackTset
    {
        [Fact]
        public void ReversingStackWithMultipleElements()
        {
            // Arrange
            StackWithReverse testStack = new StackWithReverse();
            testStack.Push(1);
            testStack.Push(2);
            testStack.Push(3);

            // Act
            testStack.ReverseStack();

            // Assert
            Assert.Equal(1, testStack.Peek());
        }
        [Fact]
        public void ReversingStackWithOneElementTest()
        {
            // Arrange
            StackWithReverse testStack = new StackWithReverse();
            testStack.Push(1);

            // Act
            testStack.ReverseStack();

            // Assert
            Assert.Equal(1, testStack.Peek());
        }
        [Fact]
        public void ReversingEmptyStackTest()
        {
            // Arrange
            StackWithReverse testStack = new StackWithReverse();

            // Act
            testStack.ReverseStack();

            // Assert
            Assert.True(testStack.IsEmpty());
        }
    }
}
