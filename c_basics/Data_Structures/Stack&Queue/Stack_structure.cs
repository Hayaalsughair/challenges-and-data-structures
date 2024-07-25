﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_basics.Data_Structures.Stack_Queue
{
    public class Stack_structure
    {
        private Node top;

        public Stack_structure()
        {
            top = null;
        }

        public void Push(int data)
        {
            Node newNode = new Node(data);
            newNode.Next = top;
            top = newNode;
        }
        public int Pop()
        {
            if (IsEmpty())
            {
                throw new Exception("Stack is empty.");
            }

            int poppedData = top.Data;
            top = top.Next;
            return poppedData;
        }
        public int Peek() =>
            IsEmpty()
                ? throw new Exception("Stack is empty.")
                : top.Data;

        public bool IsEmpty() => top == null;

    }
}
