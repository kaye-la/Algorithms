using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.HashTable
{
    public class HashTableNode<T>
    {
        public int Key { get; set; }
        public T Value { get; set; }

        public HashTableNode(int key, T value)
        {
            Key = key;
            Value = value;
        }
    }
}
