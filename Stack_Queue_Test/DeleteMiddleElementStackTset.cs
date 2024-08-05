using c_basics.Data_Structures.Stack_Queue.DeleteMiddleElement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Queue_Test
{
    public class DeleteMiddleElementStackTset
    {
        [Fact]
        public void DeleteMiddle_OddSizedStack_RemovesMiddleElement()
        {
            // Arrange
            StackWithDeleteMiddle testStack = new StackWithDeleteMiddle();
            testStack.Push(1);
            testStack.Push(2);
            testStack.Push(3);
            testStack.Push(4);
            testStack.Push(5);

            // Act
            testStack.DeleteMiddle();


            // Assert
            Assert.Equal(5, testStack.Pop());
            Assert.Equal(4, testStack.Pop());
            Assert.Equal(2, testStack.Pop());
            Assert.Equal(1, testStack.Pop());
            Assert.True(testStack.IsEmpty());
        }
        [Fact]
        public void DeleteMiddle_EvenSizedStack_RemovesLowerMiddleElement()
        {
            // Arrange
            StackWithDeleteMiddle stack = new StackWithDeleteMiddle();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);


            // Act
            stack.DeleteMiddle();

            // Assert
            Assert.Equal(4, stack.Pop());
            Assert.Equal(3, stack.Pop());
            Assert.Equal(1, stack.Pop());
            Assert.True(stack.IsEmpty());
        }
    }
}
