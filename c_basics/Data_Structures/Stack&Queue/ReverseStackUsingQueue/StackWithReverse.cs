using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_basics.Data_Structures.Stack_Queue.ReverseStackUsingQueue
{
    public class StackWithReverse : Stack_structure
    {
        public void ReverseStack()
        {
            if (IsEmpty() || top.Next == null)
            {
                return ;
            }

            Queue_structure queue = new Queue_structure();

            while (!IsEmpty())
            {
                queue.Enqueue(Pop());
            }

            while (!queue.IsEmpty())
            {
                Push(queue.Dequeue());
            }
        }
    }
}
