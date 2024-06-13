﻿using System.ComponentModel.Design;
using System.Linq.Expressions;

namespace c_basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Reversed Array 
            int[] arr0 = { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine("Reversed array:");
            ReversArr(arr0);

            Console.WriteLine("\n-----------------------------------------");

            //Most  Frequent Number  
            int[] arr = { 1, 1, 2, 2, 3, 3, 3, 1, 1, 5, 5, 6, 7, 8, 2, 1, 1 };
            int n = arr.Length;

            Console.WriteLine("Most frequent number:");
            Console.WriteLine(MostFrequent(arr, n));

            //Max Value in Array 
            Console.WriteLine("-----------------------------------------");
            int[] arr2 = { 10, 15, 8, 6, 12 };
            Console.WriteLine("Max value in array:");
            Console.WriteLine(MaximumValue(arr2));

            //Remove-Middle-Value
            Console.WriteLine("-----------------------------------------");
            int[] arr3 = { 1, 2, 3, 4, 5 };
            int[] result = RemoveMiddleValue(arr3);
            Console.WriteLine($"Removing the middle number :\n input: {string.Join(",", arr3)} output: {string.Join(",", result)}");

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
    }
}

