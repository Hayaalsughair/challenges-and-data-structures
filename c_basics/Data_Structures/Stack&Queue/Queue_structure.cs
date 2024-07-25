using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_basics.Data_Structures.Stack_Queue
{
    public class Queue_structure
    {
        private Node front;
        private Node back; 

        public Queue_structure()
        {
            front = back = null;
        }

        public void Enqueue(int data)
        {
            Node newNode = new Node(data);

            if (IsEmpty())
            {
                front = back = newNode;
            }
            else
            {
                back.Next = newNode;
                back = newNode;
            }
        }

        public int Dequeue()
        {
            if (IsEmpty())
            {
                throw new Exception("Queue is empty.");
            }

            int dequeuedData = front.Data;
            front = front.Next;

            if (front == null)
            {
                back = null;
            }

            return dequeuedData;
        }

        public int Peek() =>
            IsEmpty()
                ? throw new Exception("Queue is empty.")
                : front.Data;
        public bool IsEmpty() => front == null;
    }
}
