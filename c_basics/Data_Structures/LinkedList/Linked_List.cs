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
                    Console.Write(Start.Data + " ");
                    Start = Start.Next;
                    count++;
                }
                Console.WriteLine(" ");
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
        public int RemoveDuplicate()
        {
            int duplicatesRemoved = 0;
            Node current = Head;
            while (current != null)
            {
                Node nextItem = current;
                while (nextItem.Next != null)
                {
                    if (nextItem.Next.Data == current.Data)
                    {
                        nextItem.Next = nextItem.Next.Next;
                        duplicatesRemoved++;
                    }
                    else
                    {
                        nextItem = nextItem.Next;
                    }
                }
                current = current.Next;
            }
            return duplicatesRemoved;
        }
        public static Linked_List MergeSortedLists(Linked_List list1, Linked_List list2)
        {
            if (list1.Head == null && list2.Head == null)
            {
                Console.WriteLine("Both Linked Lists are empty");
                return new Linked_List();

            }
            Linked_List mergeSortedList = new Linked_List();
            Node current =  mergeSortedList.Head;

            Node pointerA = list1.Head;
            Node pointerB= list2.Head;

            while (pointerA != null && pointerB != null)
            {
                if( pointerA.Data < pointerB.Data)
                {
                    //Use AddEnd Method  
                    mergeSortedList.AddEnd(pointerA.Data);
                    pointerA = pointerA.Next;
                }
                else
                {
                    mergeSortedList.AddEnd(pointerB.Data);
                    pointerB = pointerB.Next;

                }
            }
            //Add the remaining Nodes in Both LinkedList  
            while (pointerA != null)
            {
                mergeSortedList.AddEnd(pointerA.Data);
                pointerA = pointerA.Next;
            }

            while (pointerB != null)
            {
                mergeSortedList.AddEnd(pointerB.Data);
                pointerB = pointerB.Next;
            }

            return mergeSortedList;
        }
        public int Length()
        {
            int length = 0;
            Node current = Head;
            while (current != null)
            {
                length++;
                current = current.Next;
            }
            return length;
        }
        public void RotateLeft(int k)
        {
            if (Head == null || k == 0)
            {
                return;
            }

            int length = Length();
            if (k > length) return;

            // Find the new head at position k
            Node current = Head;
            for (int i = 1; i < k; i++)
            {
                current = current.Next;
            }

            Node newHead = current.Next; 
            current.Next = null;
            Tail.Next = Head; 
            Head = newHead; 
        }


    }
}

