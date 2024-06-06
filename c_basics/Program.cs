namespace c_basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr0 = { 1, 2, 3, 4, 5, 6, 7 };

            Console.WriteLine("Reversed array:");
            ReversArr(arr0);

            int[] arr = { 1, 1, 2, 2, 3, 3, 3, 1, 1, 5, 5, 6, 7, 8, 2, 1, 1 };
            int n = arr.Length;

            // Print a new line before the most frequent number
            Console.WriteLine();
            Console.WriteLine("Most frequent number:");
            Console.WriteLine(mostFrequent(arr, n));
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

        public static int mostFrequent(int[] arr, int n)
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
    }
}
