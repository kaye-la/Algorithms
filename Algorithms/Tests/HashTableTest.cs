using Algorithms.HashTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Tests
{
    public class HashTableTest
    {
        public static void run()
        {
            #region Hash Table Test
            Console.WriteLine("\n----------------Hash Table Test-----------------");
            Console.WriteLine("-------Hash Table Array Test:");
            HashTableArray<string> tableArray = new HashTableArray<string>(3);
            tableArray.Add(312, "abcbca");
            tableArray.Add(123, "qwer");
            tableArray.Add(2, "qw");
            tableArray.View();

            Console.WriteLine("\nHash-table after removing by key 123:");
            tableArray.Remove(123);
            tableArray.View();

            Console.WriteLine("\n------Hash Table List Test:");
            HashTableList<string> tableList = new HashTableList<string>(5);
            tableList.Add(1, "abc");
            tableList.Add(6, "abc");
            tableList.Add(11, "abc");
            tableList.Add(16, "a");
            tableList.Add(0, "bc");
            tableList.View();

            Console.WriteLine("\nHash-table after removing by key 11 & 0:");
            tableList.Remove(11);
            tableList.Remove(0);
            tableList.View();
            #endregion
        }
    }
}
