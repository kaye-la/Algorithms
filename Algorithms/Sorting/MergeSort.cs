using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Algorithms.Sorting
{
    public class MergeSort<T> where T : IComparable
    {
        private static void Sort(object o)
        {
            var a = (T[])((object[])o)[0];
            var l = (int)((object[])o)[1];
            var r = (int)((object[])o)[2];
            int m;

            if (l >= r) // condition to exit recursion
                return;

            m = (l + r) / 2;

            var firstThread = new Thread(Sort);
            firstThread.Start(new object[] { a, l, m });

            var secondThread = new Thread(Sort);
            secondThread.Start(new object[] { a, m + 1, r });

            while (firstThread.IsAlive || secondThread.IsAlive)
                Thread.Sleep(20);

            Merge(a, l, r, m);
            return;
        }

        public static void Sort(T[] a, int l, int r)
        {
            Sort(new object[] { a, l, r });
        }

        private static void Merge(T[] array, int left, int right, int medium)
        {
            int j = left;
            int k = medium + 1;
            int count = right - left + 1;

            if (count <= 1)
                return;

            T[] tempArray = new T[count];

            for (int i = 0; i < count; ++i)
            {
                if (j <= medium && k <= right)
                {
                    if (array[j].CompareTo(array[k]) < 0)
                        tempArray[i] = array[j++];
                    else
                        tempArray[i] = array[k++];
                }
                else
                {
                    if (j <= medium)
                        tempArray[i] = array[j++];
                    else
                        tempArray[i] = array[k++];
                }
            }

            j = 0;
            for (int i = left; i <= right; ++i)
            {
                array[i] = tempArray[j++];
            }
        }
    }
}
