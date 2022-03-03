using System;

namespace Exercise003
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Sorting s = new Sorting();
            // Create random arrays with 10 and 100 items
            int[] sortMeTen = Randomizer(10);
            int[] sortMeHundred = Randomizer(100);

            // Comment these in if you want to see the order before the sorting
            /* foreach (int i in sortMeTen)
            {
                Console.Write(i + ",");
            }
            Console.WriteLine();

            foreach (int i in sortMeHundred)
            {
                Console.Write(i + ",");
            }
            Console.WriteLine(); */

            // Mergesort 10 items and print the result
            int[] sorted = s.MergeSort(sortMeTen);
            foreach (int i in sorted)
            {
                Console.Write(i + ",");
            }
            Console.WriteLine();

            // Mergesort 100 items and print the result
            sorted = s.MergeSort(sortMeHundred);
            foreach (int i in sorted)
            {
                Console.Write(i + ",");
            }
            Console.WriteLine();

            // Quicksort 10 items and print the result
            sorted = s.QuickSort(sortMeTen, 0, sortMeTen.Length - 1);
            foreach (int i in sorted)
            {
                Console.Write(i + ",");
            }
            Console.WriteLine();

            // Quicksort 100 items and print the result
            sorted = s.QuickSort(sortMeHundred, 0, sortMeHundred.Length - 1);
            foreach (int i in sorted)
            {
                Console.Write(i + ",");
            }
            Console.WriteLine();
        }

        // Randomizer to create arrays with random numbers
        public static int[] Randomizer(int n)
        {
            Random random = new Random();
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                // integers between 1 and 1000 are enough for us
                arr[i] = random.Next(1, 1001);
            }
            return arr;
        }
    }
}