using Algorithms.Sorting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Bubble Sorting Test
            Console.WriteLine("\n-----------Bubble Sorting-------------");

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

            Console.ReadKey();
        }
    }
}
