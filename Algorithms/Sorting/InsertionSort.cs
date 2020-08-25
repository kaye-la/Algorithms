using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    public class InsertionSort<T> where T : IComparable
    {
        public static void Sort(T[] arr)
        {
            T temp;
            int n = arr.Length;
            
            for (int i = 0; i < n; i++)
            {
                int j = i;
                temp = arr[i];

                while (j > 0 && arr[j - 1].CompareTo(temp) > 0)
                {
                    arr[j] = arr[j - 1];
                    j -= 1;
                }
                arr[j] = temp;
            }
        }
    }
}
