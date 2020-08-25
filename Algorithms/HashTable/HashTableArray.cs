using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.HashTable
{
    /// <summary>
    /// HashTable, реализованный с помощью одномерного массива
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class HashTableArray<T>
    {
        private int count = 0;
        HashTableNode<T>[] table;

        public int Count
        {
            get { return count; }
        }

        #region Constructors
        public HashTableArray()
        {
            table = new HashTableNode<T>[0];
        }

        public HashTableArray(int size)
        {
            table = new HashTableNode<T>[size];
        }
        #endregion

        private void Resize(int size)
        {
            var newTable = new HashTableNode<T>[size];
            var temp = table;
            table = newTable;

            foreach (var el in temp)
                Add(el.Key, el.Value);
        }

        private int FullGetIndexByKey(int key)      
        {
            var index = key.GetHashCode() % table.Length;

            while (true)
            {
                if (table[index] == null || table[index].Key.Equals(key))
                    return index;
                index += 1;
                if (index >= table.Length)
                    index = 0;
            }
        }
        
        /// <summary>
        /// Поиск значения по ключу
        /// </summary>
        /// <param name="key">Ключ</param>
        /// <returns>Значение</returns>
        public T FindByKey(int key)
        {
            var index = FullGetIndexByKey(key);

            if (table[index] == null)
            {
                Console.WriteLine("Ключ " + key + " не найден!");
                return default(T);
            }
            return table[index].Value;
        }

        /// <summary>
        /// Добавление записи
        /// </summary>
        /// <param name="key">Ключ</param>
        /// <param name="value">Значение</param>
        public void Add(int key, T value)
        {
            if (count >= table.Length * 0.75)
                Resize(table.Length << 1);

            HashTableNode<T> newHash = new HashTableNode<T>(key, value);
            int index = FullGetIndexByKey(key);
            table[index] = newHash;
            count += 1;
        }

        /// <summary>
        /// Удаление записи по ключу
        /// </summary>
        /// <param name="key">Ключ</param>
        public void Remove(int key)
        {
            int index = FullGetIndexByKey(key);

            if (table[index] != null)
            {
                table[index] = null;
                count -= 1;
                return ;
            }
            else
                Console.WriteLine("Ключ " + key + " не найден!");
        }

        public void View()
        {
            for (int i = 0; i < table.Length; i++)
            {
                if (table[i] == null)
                    continue;
                Console.WriteLine("Ключ = " + table[i].Key.ToString() + " Значение = " + table[i].Value.ToString());
            }
        }
    }
}
