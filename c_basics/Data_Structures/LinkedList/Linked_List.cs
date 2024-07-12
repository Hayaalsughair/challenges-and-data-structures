using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using c_basics.Data_Structures.LinkedList;
namespace c_basics.Data_Structures.LinkedList
{
    public class Linked_List
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }
        public Linked_List()
        {
            Head = null;
            Tail = null;
        }

        public void AddEnd(int value)
        {
            Node item = new Node(value);
            if (Head == null)
            {
                Head = item;
                Tail = item;

            }
            else
            {
                Tail.Next = item;
                Tail = item;
            }
        }
        public void AddFirst(int value)
        {
            Node item = new Node(value);
            if (Head == null) 
            {
                Head = item;
                Tail = item;
            }
            else
            {
                item.Next = Head; 
                Head = item;
            }

        }
        public int PrintList()
        {
            Node Start = Head;
            if (Start == null)
            {
                Console.WriteLine("Linked List is Empty");
                return 0;
            }
            else
            {
                int count = 0;
                while (Start != null)
                {
                    Console.WriteLine(Start.Data);
                    Start = Start.Next;
                    count++;
                }
                return count;
            }
        }
        public bool Include(int value)
        {
            Node current = Head;
            int position = 1;
            while (current != null)
            {
                if (current.Data == value)
                {
                    Console.WriteLine($"Item: {value} Found at: {position}");
                    return true;
                }
                current = current.Next;
                position++;
            }

            Console.WriteLine("Item Not Found");

            return false;
        }
        public void Remove(int value)
        {
            if (Head == null)
            {
                Console.WriteLine("List is Empty");
                return;
            }

            // Element in the Head
            if (Head.Data == value)
            {
                Head = Head.Next;
                if (Head == null) 
                {
                    Tail = null;
                }
                return;
            }

            // Element in the Middle or End
            Node previous = Head;
            Node current = Head.Next;
            while (current != null)
            {
                if (current.Data == value)
                {
                    previous.Next = current.Next;
                    // Remove Last Element
                    if (current.Next == null)
                    {
                        Tail = previous;
                    }
                    return;
                }
                previous = current;
                current = current.Next;
            }

            // Element Not Found
            if (current == null)
            {
                Console.WriteLine("Element Not Found");
            }
        }

    }
}
