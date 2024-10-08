using c_basics.Challenges.Common_Elements;
using c_basics.Data_Structures.LinkedList;
using c_basics.Data_Structures.Stack_Queue;
using c_basics.Data_Structures.Stack_Queue.DeleteMiddleElement;
using c_basics.Data_Structures.Stack_Queue.MinStack;
using c_basics.Data_Structures.Stack_Queue.ReverseStackUsingQueue;
using c_basics.Data_Structures.Trees;
using c_basics.Data_Structures.Trees.TreeImplementation;
using c_basics.Reverse_Words;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq.Expressions;

namespace c_basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Reversed Array 
            //int[] arr0 = { 1, 2, 3, 4, 5, 6, 7 };
            //Console.WriteLine("Reversed array:");
            //ReversArr(arr0);

            //Console.WriteLine("\n-----------------------------------------");

            ////Most  Frequent Number  
            //int[] arr = { 1, 1, 2, 2, 3, 3, 3, 1, 1, 5, 5, 6, 7, 8, 2, 1, 1 };
            //int n = arr.Length;

            //Console.WriteLine("Most frequent number:");
            //Console.WriteLine(MostFrequent(arr, n));

            ////Max Value in Array 
            //Console.WriteLine("-----------------------------------------");
            //int[] arr2 = { 10, 15, 8, 6, 12 };
            //Console.WriteLine("Max value in array:");
            //Console.WriteLine(MaximumValue(arr2));

            ////Remove-Middle-Value
            //Console.WriteLine("-----------------------------------------");
            //int[] arr3 = { 1, 2, 3, 4, 5 };
            //int[] result = RemoveMiddleValue(arr3);
            //Console.WriteLine($"Removing the middle number :\n input: {string.Join(",", arr3)} output: {string.Join(",", result)}");

            ////Insert-Middle-Value
            //Console.WriteLine("-----------------------------------------");
            //int[] arr4 = { 1, 2, 3, 4 };
            //int middleValue = 5;
            //int[] result1= MiddleValue(arr4, middleValue);
            //Console.WriteLine($"Insert Middle Value: \n Middle Value: {middleValue} Array: {string.Join(",", arr4)} \n Output: {string.Join(",", result1)}");


            ////Duplicates Number 
            //Console.WriteLine("-----------------------------------------");
            //int[] arr5 = { 5, 10, 16, 20, 10, 16 };
            //int[] result2=FindDuplicates(arr5);
            //Console.WriteLine($"Array: {string.Join(",",arr5)}\n Duplicates Number: {string.Join(",",result2)}");

            //Common Elements
            //Console.WriteLine("-----------------------------------------");
            //int[] arr6 = { 1, 2, 3, 0 };
            //int[] arr7 = { 5, 7, 4, 9 };
            //int[] commonResult = solutionCommonElement.CommonElements(arr6, arr7);
            //Console.WriteLine($"Array 1 : {string.Join(",", arr6)}\nArray 2: {string.Join(",", arr7)}\nCommon Number: {string.Join(",", commonResult)}");

            //Reverse word 
            //Console.WriteLine("-----------------------------------------");
            //string statment1 = "csharp is programming language";
            //string statment2 = "Reverse the words in this sentence";
            //string statment3 = "challenges and data structures";
            //string sol = ReverseWord.ReverseWords(statment1);
            //string sol2 = ReverseWord.ReverseWords(statment2);
            //string sol3 = ReverseWord.ReverseWords(statment3);
            //Console.WriteLine($"Input: {statment1}\tOutput: {sol}\nInput: {statment2}\tOutput: {sol2}\nInput: {statment3}\tOutput : {sol3}");

            //Linked List 
            //Linked_List myList = new Linked_List();
            //myList.AddEnd(1);
            //myList.AddEnd(2);
            //myList.AddEnd(5);
            //myList.AddEnd(10);
            //Console.WriteLine("First LinkedList");
            //myList.PrintList();
            //Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~"); 

            //myList.Include(5);
            //Console.WriteLine("Print List Before Remove elemnt:");
            //myList.PrintList();
            //myList.Remove(10);
            //Console.WriteLine();
            //Console.WriteLine("Print List After Remove elemnt: ");
            //myList.PrintList();

            //Linked - List - Remove - Duplicates
            //Console.WriteLine($"Print Array Before Remove Duplicates");
            //myList.PrintList();
            //Console.WriteLine("----------------------------------------");
            //Console.WriteLine("Array After Remove Duplicates ");
            //myList.RemoveDuplicate();
            //myList.PrintList();

            // Console.WriteLine("merge Sorted Linked List:");
            //Linked_List myList2 = new Linked_List();
            //myList2.AddEnd(3);
            //myList2.AddEnd(4);
            //myList2.AddEnd(12);
            //myList2.AddEnd(13);
            //myList2.AddEnd(14);
            //Console.WriteLine("Second LinkedList");
            //myList2 .PrintList();
            //Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~");
            //// Merge Sorted Lists
            //Console.WriteLine("Merged Sorted Linked List:");
            //Linked_List mergedList = Linked_List.MergeSortedLists(myList, myList2);
            //mergedList.PrintList();
            //Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~Queue~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            //Queue_structure myQueue = new Queue_structure();

            //myQueue.Enqueue(10);
            //myQueue.Enqueue(40);
            //myQueue.Enqueue(83);
            //myQueue.Enqueue(30);


            //Console.WriteLine($"Peek\t\t\tresult: {myQueue.Peek()} expected:[10]");

            //myQueue.Dequeue();
            //Console.WriteLine($"Peek after Dequeue\tresult: {myQueue.Peek()} expected:[40]");
            //Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~Stack~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            //Stack_structure myStack = new Stack_structure();
            //myStack.Push(10);
            //myStack.Push(30);
            //myStack.Push(9);
            //myStack.Push(54);
            //Console.WriteLine($"Peek\t\t\tresult: {myStack.Peek()} expected:[54]");
            //myStack.Pop();
            //Console.WriteLine($"Peek after poped\tresult: {myStack.Peek()} expected:[9]");
            // StackWithReverse stack = new StackWithReverse();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);
            //stack.Push(5);

            //Console.WriteLine($"Satck Before Reverse, Top:{stack.Peek()}");
            //stack.ReverseStack();
            //Console.WriteLine($"Satck After Reverse, Top:{stack.Peek()}");
            //Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
            //Console.WriteLine("We push [6] and [7]");
            //stack.Push(6);
            //stack.Push(7);
            //Console.WriteLine($"Satck Before Reverse, Top:{stack.Peek()}"); 
            //stack.ReverseStack();
            //Console.WriteLine($"Satck After Reverse, Top:{stack.Peek()}");
            //StackWithDeleteMiddle stack = new StackWithDeleteMiddle();
            //stack.Push(10);
            //stack.Push(20);
            //stack.Push(30);
            //stack.Push(40);
            ////stack.Push(50);
            //Console.WriteLine("Satck before delete middle value ");
            //stack.PrintStack();
            //stack.DeleteMiddle();
            //Console.WriteLine("\nSatck after delete middle value ");
            //stack.PrintStack();
            //MinStack minStack = new MinStack();

            //minStack.Push(15);
            //minStack.Push(7);
            //minStack.Push(12);
            //minStack.Push(3);

            //minStack.PrintStack(); 

            //Console.WriteLine($"MinVaule:{minStack.GetMin()}");

            //minStack.Pop();
            //minStack.PrintStack(); 

            //Console.WriteLine($"MinValue After Pooped: {minStack.GetMin()}");
            //Console.WriteLine($"Top value: {minStack.Top()}");

            //minStack.Push(2);
            //Console.WriteLine($"MinStack After Push [2]:");
            //minStack.PrintStack();

            //Console.WriteLine($"MinValue After Push [2] :{minStack.GetMin()}");

            //BinarySearchTree bst = new BinarySearchTree();
            //bst.Add(5);
            //bst.Add(3);
            //bst.Add(10);
            //bst.Add(1);
            //bst.Add(9);
            //bst.Add(16);
            //bst.Add(15);

            //Console.WriteLine("PostOrder Traversal:");
            //bst.PostOrder(bst.Root);
            //Console.WriteLine("\nInOrder Traversal:");
            //bst.InOrder(bst.Root);
            //Console.WriteLine("\nPreOrder Traversal:");
            //bst.PreOrder(bst.Root);
            //Console.WriteLine($"\nTree contains [15]: {bst.Contains(15)}"); 
            //Console.WriteLine($"Tree contains [90]: {bst.Contains(90)}"); 

            //bst.Remove(3);
            //Console.WriteLine("Element [3] removed from the Binary Search Tree.");

            //Console.WriteLine($"Tree contains 30 after removal: {bst.Contains(3)}"); 

            //MiroorTree miroor = new MiroorTree();
            //miroor.Add(5);
            //miroor.Add(3);
            //miroor.Add(10);
            //miroor.Add(1);
            //Console.WriteLine("Before Mirror:");
            //miroor.InOrder(miroor.Root);

            //Console.WriteLine("\nAfter Mirror:");
            //miroor.MirrorTree();
            //miroor.InOrder(miroor.Root);
            //SecondMaxValue Btree = new SecondMaxValue();
            //Btree.Root = new TNode(10);
            //Btree.Root.Left = new TNode(5);
            //Btree.Root.Right = new TNode(20);
            //Btree.Root.Left.Left = new TNode(3);
            //Btree.Root.Left.Right = new TNode(7);
            //Btree.Root.Right.Left = new TNode(15);
            //Btree.Root.Right.Right = new TNode(25);

            //int secondMax = Btree.FindSecondMax();
            //Console.WriteLine($"second value = {secondMax}");

            //LeafSum sumNodes = new LeafSum();
            //sumNodes.Root = new TNode(10);
            //sumNodes.Root.Left = new TNode(5);
            //sumNodes.Root.Right = new TNode(20);
            //sumNodes.Root.Left.Left = new TNode(3);
            //sumNodes.Root.Left.Right = new TNode(7);

            //int sumValue = sumNodes.SumOfLeafNodes();
            //Console.WriteLine($"The leaf nodes are 3, 7, and 20.\nSum Of Dead Node = {sumValue}");

            //LargestLevelValue Btree = new LargestLevelValue();
            //Btree.Root = new TNode(4);
            //Btree.Root.Left = new TNode(9);
            //Btree.Root.Right = new TNode(2);
            //Btree.Root.Right.Right = new TNode(7);
            //Btree.Root.Left.Left = new TNode(3);
            //Btree.Root.Left.Right = new TNode(5);

            //List<int> largestValues = Btree.LargestValueEachLevel(Btree.Root);

            //Console.WriteLine("Largest values at each level:");
            //Console.WriteLine(string.Join(", ", largestValues));

            //Linked_List rotatList = new Linked_List();

            //// Add nodes to the list
            //rotatList.AddFirst(6);
            //rotatList.AddFirst(5);
            //rotatList.AddFirst(4);
            //rotatList.AddFirst(3);
            //rotatList.AddFirst(2);
            //rotatList.AddFirst(1);

            //Console.WriteLine("Original List:");
            //rotatList.PrintList();
            //Console.WriteLine("List After Rotat:\nK=3");
            //int k = 3;
            //rotatList.RotateLeft(k);
            //rotatList.PrintList();



            //RightViewPrint Rtree = new RightViewPrint();
            //Rtree.Root = new TNode(4);
            //Rtree.Root.Left = new TNode(9);
            //Rtree.Root.Right = new TNode(2);
            //Rtree.Root.Right.Right = new TNode(7);
            //Rtree.Root.Right.Right.Right = new TNode(8);

            //Rtree.Root = new TNode(2);
            //Rtree.Root.Left = new TNode(3);
            //Rtree.Root.Right = new TNode(5);
            //Rtree.Root.Left.Left = new TNode(4);
            //Rtree.Root.Right.Right = new TNode(6);
            //Rtree.Root.Left.Left.Right = new TNode(7);
            //Console.WriteLine("Right values =");
            //Rtree.PrintRightView();

            MaxLevelNodes Btree1 = new MaxLevelNodes();
            Btree1.Root = new TNode(1);
            Btree1.Root.Left = new TNode(2);
            Btree1.Root.Right = new TNode(3);
            Btree1.Root.Left.Left = new TNode(4);
            Btree1.Root.Left.Right = new TNode(5);
            Btree1.Root.Right.Right = new TNode(6);
            Btree1.Root.Left.Left.Left = new TNode(7);

            int maxLevel1 = Btree1.FindMaxLevelNodes();
            Console.WriteLine("Max Level in " + maxLevel1);

        }

        static int[] ReversArr(int[] arr0)
        {
            int start = 0;
            int end = arr0.Length - 1;

            while (start < end)
            {
                int temp = arr0[start];
                arr0[start] = arr0[end];
                arr0[end] = temp;

                start++;
                end--;
            }

            foreach (int item in arr0)
            {
                Console.Write(item + " ");
            }
            return arr0;
        }
        public static int MostFrequent(int[] arr, int n)
        {
            int maxcount = 0;
            int element_having_max_freq = 0;
            for (int i = 0; i < n; i++)
            {
                int count = 0;
                for (int j = 0; j < n; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }

                if (count > maxcount)
                {
                    maxcount = count;
                    element_having_max_freq = arr[i];
                }
            }

            return element_having_max_freq;
        }
        public static int MaximumValue(int[] maxArr)
        {
            int maxInt = 0;
            for (int i = 0; i < maxArr.Length; i++)
            {
                if (maxArr[i] > maxInt)
                {
                    maxInt = maxArr[i];
                }
            }
            return maxInt;
        }
        public static int[] RemoveMiddleValue(int[] arr)
        {
            int middleIndex = arr.Length / 2;
            int[] newArr = new int[arr.Length - 1]; 

            for (int i = 0; i < middleIndex; i++)
            {
                newArr[i] = arr[i];
            }

            for (int i = middleIndex; i < newArr.Length; i++)
            {
                newArr[i] = arr[i + 1];
            }
               
            return newArr;
            
        }
        public static int[] MiddleValue(int[] arr, int value)
        {
            int middleIndex= arr.Length / 2;
            int[] newArray = new int[arr.Length + 1];


            for (int i = 0; i < middleIndex; i++)
            {
                newArray[i] = arr[i];
            }

            newArray[middleIndex] = value;

            for (int i = middleIndex; i < arr.Length; i++)
            {
                newArray[i + 1] = arr[i];
            }
            return newArray;
        }
        public static int[] FindDuplicates(int[] arr) {
            List<int> duplicateNum = new List<int>();

            for (int i = 0; i < arr.Length; i++) { 
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[j] == arr[i])
                    {
                        duplicateNum.Add(arr[i]);
                    }

                } 
            }

            return duplicateNum.ToArray();
        }


    }

}

