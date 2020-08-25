using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Tests
{
    public class SetTest
    {
        public static void run()
        {
            #region Set Test
            Console.WriteLine("\n-----------------Set test-------------------");
            int[] temp = { 1, 3, 2 };
            Set<int> array = new Set<int>(temp);

            Console.WriteLine("Созданный массив: ");
            Console.WriteLine(array);

            int[] temp2 = { 1, 4, 5 };
            Set<int> tempCheck = new Set<int>(temp2);

            Set<int> arrayUnion = array.Union(tempCheck);
            Console.WriteLine("\nОбъединение массивов: ");
            Console.WriteLine("{0} union {1} => {2}", array, tempCheck, arrayUnion);

            Set<int> arrayIntersection = array.Intersection(tempCheck);
            Console.WriteLine("\nПересечение массивов: ");
            Console.WriteLine("{0} intersection {1} => {2}", array, tempCheck, arrayIntersection);

            Set<int> arrayDifference = array.Difference(tempCheck);
            Console.WriteLine("\nРазность массивов: ");
            Console.WriteLine("{0} difference {1} => {2}", array, tempCheck, arrayDifference);

            List<Set<int>> arrayCombinations = array.Combinations();
            Console.WriteLine("\nВсе сочетания массива без повторений: ");
            foreach (var a in arrayCombinations)
                Console.WriteLine(a);

            array.Add(7);
            Console.WriteLine("\nМассив после добавления: ");
            array.View();

            array.Remove(2);
            Console.WriteLine("\nМассив после Remove: ");
            array.View();

            array.RemoveAtIndex(2);
            Console.WriteLine("\nМассив после RemoveAtIndex: ");
            array.View();
            #endregion
        }
    }
}
