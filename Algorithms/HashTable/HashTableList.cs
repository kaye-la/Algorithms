using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.HashTable
{
    public class HashTableList<T>
    {
        private List<HashTableNode<T>>[] table;
        public int Size { get; private set; }
        public int Count { get; private set; }

        public HashTableList(int size)
        {
            Size = size;
            table = new List<HashTableNode<T>>[Size];
            for (int i = 0; i < size; i++)
                table[i] = new List<HashTableNode<T>>();
        }

        public int Hash(int key)
        {
            return key % Size;
        }

        public void Add(int key, T value)
        {
            HashTableNode<T> temp = new HashTableNode<T>(key, value);
            int index = Hash(key);
            table[index].Add(temp);
            Count += 1;
        }


        public T FindByKey(int key)
        {
            int index = Hash(key);
            var nodeIndex = table[index].FindIndex(tt => tt != null && tt.Key == key);

            if (nodeIndex < 0)
                return default(T);
            return table[index][nodeIndex].Value;
        }


        public void Remove(int key)
        {
            int index = Hash(key);
            var nodeIndex = table[index].FindIndex(tt => tt != null && tt.Key == key);

            if (nodeIndex < 0) return;
            table[index].RemoveAt(nodeIndex);
            Count -= 1;
        }

        public void Resize(int size)
        {
            var temp = table;
            Size = size;
            table = new List<HashTableNode<T>>[size];

            foreach (var ar in temp)
                foreach (var el in ar)
                    Add(el.Key, el.Value);
        }

        public void View()
        {
            for (int i = 0; i < Size; i++)
            {
                foreach (var el in table[i])
                {
                    if (el == null)
                        continue;
                    Console.WriteLine("Ключ = " + el.Key.ToString() + " Значение = " + el.Value.ToString());
                }
            }
        }
    }
}
