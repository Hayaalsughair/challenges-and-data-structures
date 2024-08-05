using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace c_basics.Data_Structures.Stack_Queue.DeleteMiddleElement
{
    public class StackWithDeleteMiddle: Stack_structure
    {
        public void DeleteMiddle()
        {
            Stack_structure stack = new Stack_structure();
            int count = 0;

            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty");
                return ;
            }
            while (this.top != null)
            {
                stack.Push(this.Pop());
                count++;
            }
            int middleIndex = (count % 2 == 0) ? (count / 2) - 1 : count / 2;
            for (int i = 0; i < count; i++)
            {
                int element = stack.Pop();

                if (i != middleIndex)
                {
                    Push(element);
                }
            }
        }
    }
}
