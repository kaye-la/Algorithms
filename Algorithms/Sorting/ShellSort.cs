using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    public class ShellSort<T> where T : IComparable
    {
        public static void Sort(T[] arr)
        {
            int n = arr.Length;
            int step = n / 2;

            while (step > 0)
            {
                for (int i = step; i < n; i++)
                {
                    int j;
                    T temp = arr[i];

                    for (j = i - step; (j >= 0) && (arr[j].CompareTo(temp) > 0); j -= step)
                        arr[j + step] = arr[j];
                    arr[j + step] = temp;
                }
                step /= 2;
            }
        }
    }
}
