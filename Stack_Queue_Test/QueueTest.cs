using c_basics.Data_Structures.Stack_Queue;

namespace Stack_Queue_Test
{
    public class QueueTest
    {
        [Fact]
        public void EnqueueNodeIntoQueue()
        {
            // Arrange
            Queue_structure testQueue = new Queue_structure();

            // Act
            testQueue.Enqueue(10);
            testQueue.Enqueue(20);

            // Assert
            Assert.Equal(10, testQueue.Peek());
        }

        [Fact]
        public void DequeueNodeIntoQueue()
        {
            // Arrange
            Queue_structure testQueue = new Queue_structure();

            // Act
            testQueue.Enqueue(10);
            testQueue.Enqueue(30);
            testQueue.Enqueue(20);

            testQueue.Dequeue();

            // Assert
            Assert.Equal(30, testQueue.Peek());
        }

        [Fact]
        public void IsEmpty_ShouldReturnTrueIfQueueIsEmpty()
        {
            // Arrange
            Queue_structure testQueue = new Queue_structure();

            // Act
            bool isEmpty = testQueue.IsEmpty();

            // Assert
            Assert.True(isEmpty);
        }
    }
}