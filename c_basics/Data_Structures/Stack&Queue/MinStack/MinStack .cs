using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_basics.Data_Structures.Stack_Queue.MinStack
{
    public class MinStack : Stack_structure
    {
        private Stack_structure stack;
        private Stack_structure minStack;

        public MinStack()
        {
            stack = new Stack_structure();
            minStack = new Stack_structure();
        }

        public void Push(int data)
        {
            stack.Push(data);
            if (minStack.IsEmpty() || data <= minStack.Peek())
            {
                minStack.Push(data);
            }
        }

        public int Pop()
        {
            if (stack.IsEmpty())
            {
                throw new Exception("Stack is empty");
            }

            int poppedData = stack.Pop();
            if (poppedData == minStack.Peek())
            {
                minStack.Pop();
            }

            return poppedData;
        }

        public int Top()
        {
            if (stack.IsEmpty())
            {
                throw new Exception("Stack is empty");
            }

            return stack.Peek();
        }

        public bool IsEmpty() => stack.IsEmpty();

        public int GetMin()
        {
            if (minStack.IsEmpty())
            {
                throw new Exception("Stack is empty.");
            }

            return minStack.Peek();
        }

        public void PrintStack()
        {
            stack.PrintStack();
        }

    }
}
