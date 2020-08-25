using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    public class QuickSort<T> where T : IComparable
    {
        public static void sortMedian(T[] arr, int l, int r) //picked median as a Pivot
        {
            T x = arr[l + (r - l) / 2];
            int i = l;
            int j = r;

            while (i <= j) // partition
            {
                while (arr[i].CompareTo(x) < 0)
                    i++;
                while (arr[j].CompareTo(x) > 0)
                    j--;
                if (i <= j)
                {
                    T temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    i += 1;
                    j -= 1;
                }
            }
            if (i < r)
                sortMedian(arr, i, r);

            if (l < j)
                sortMedian(arr, l, j);
        }
    }
}
