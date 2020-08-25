using Algorithms.Sorting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Tests
{
    public class SortingTest
    {
        public static void run()
        {
            #region Bubble Sorting Test
            Console.WriteLine("\n------------Bubble Sorting test--------------");

            int[] tempSort = { 1, 10, 2, 5, 3, 7 };
            Console.Write("Array: ");
            for (int i = 0; i < tempSort.Count(); i++)
                Console.Write(tempSort[i] + " ");

            BubbleSort<int>.Sort(tempSort);
            Console.Write("\nSorted array: ");
            for (int i = 0; i < tempSort.Count(); i++)
                Console.Write(tempSort[i] + " ");
            Console.WriteLine();
            #endregion

            #region Selection Sorting Test
            Console.WriteLine("\n-----------Selection Sorting test-------------");

            tempSort = new int[] { 1, 10, 2, 5, 3, 7 };
            Console.Write("Array: ");
            for (int i = 0; i < tempSort.Count(); i++)
                Console.Write(tempSort[i] + " ");

            SelectionSort<int>.Sort(tempSort);
            Console.Write("\nSorted array: ");
            for (int i = 0; i < tempSort.Count(); i++)
                Console.Write(tempSort[i] + " ");
            Console.WriteLine();
            #endregion

            #region Insertion Sorting Test
            Console.WriteLine("\n----------Insertion Sorting test------------");

            tempSort = new int[] { 1, 10, 2, 5, 3, 7 };
            Console.Write("Array: ");
            for (int i = 0; i < tempSort.Count(); i++)
                Console.Write(tempSort[i] + " ");

            InsertionSort<int>.Sort(tempSort);
            Console.Write("\nSorted array: ");
            for (int i = 0; i < tempSort.Count(); i++)
                Console.Write(tempSort[i] + " ");
            Console.WriteLine();
            #endregion

            #region Shell Sorting Test
            Console.WriteLine("\n-------------Shell Sorting test---------------");

            tempSort = new int[] { 1, 10, 2, 5, 3, 7 };
            Console.Write("Array: ");
            for (int i = 0; i < tempSort.Count(); i++)
                Console.Write(tempSort[i] + " ");

            ShellSort<int>.Sort(tempSort);
            Console.Write("\nSorted array: ");
            for (int i = 0; i < tempSort.Count(); i++)
                Console.Write(tempSort[i] + " ");
            Console.WriteLine();
            #endregion

            #region Quick Sorting Test
            Console.WriteLine("\n-------------Quick Sorting test---------------");

            tempSort = new int[] { 1, 10, 2, 5, 3, 7 };
            Console.Write("Array: ");
            for (int i = 0; i < tempSort.Count(); i++)
                Console.Write(tempSort[i] + " ");

            QuickSort<int>.sortMedian(tempSort, 0, tempSort.Length - 1);
            Console.Write("\nSorted array: ");
            for (int i = 0; i < tempSort.Count(); i++)
                Console.Write(tempSort[i] + " ");
            Console.WriteLine();
            #endregion

            #region Merge Sorting Test
            Console.WriteLine("\n-------------Merge Sorting test---------------");

            tempSort = new int[] { 1, 10, 2, 5, 3, 7 };
            Console.Write("Array: ");
            for (int i = 0; i < tempSort.Count(); i++)
                Console.Write(tempSort[i] + " ");

            MergeSort<int>.Sort(tempSort, 0, tempSort.Length - 1);
            Console.Write("\nSorted array: ");
            for (int i = 0; i < tempSort.Count(); i++)
                Console.Write(tempSort[i] + " ");
            Console.WriteLine();
            #endregion

            #region Heap Sorting Test
            Console.WriteLine("\n-------------Heap Sorting test---------------");

            tempSort = new int[] { 1, 10, 2, 5, 3, 7 };
            Console.Write("Array: ");
            for (int i = 0; i < tempSort.Count(); i++)
                Console.Write(tempSort[i] + " ");

            HeapSort.Sort(tempSort);
            Console.Write("\nSorted array: ");
            for (int i = 0; i < tempSort.Count(); i++)
                Console.Write(tempSort[i] + " ");
            Console.WriteLine();
            #endregion
        }
    }
}
