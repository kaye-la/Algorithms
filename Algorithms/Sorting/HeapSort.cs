using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    /// <summary>
    /// Check it!
    /// </summary>
    public class HeapSort
    {
        public static void Sort(int[] arr)
        {
            int n = arr.Length;
            for (int i = n / 2 - 1; i >= 0; i--)
                makeHeap(arr, n, i);
            for (int i = n - 1; i >= 0; i--)
            {
                Swap(arr, 0, i);
                makeHeap(arr, i, 0);
            }
        }

        private static void makeHeap(int[] arr, int n, int i) // making heap; in the root - max element
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left < n && arr[left] > arr[largest])
                largest = left;
            if (right < n && arr[right] > arr[largest])
                largest = right;
            if (largest != i)
            {
                Swap(arr, i, largest);
                makeHeap(arr, n, largest);
            }
        }

        private static void Swap(int[] arr, int a, int b)
        {
            int temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }
    }
}
