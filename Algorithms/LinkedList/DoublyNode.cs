using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.LinkedList
{
    public class DoublyNode<T>
    {
        public T Data { get; set; }
        public DoublyNode<T> Next { get; set; }
        public DoublyNode<T> Prev { get; set; }

        public DoublyNode(T data)
        {
            Data = data;
            Next = null;
            Prev = null;
        }
    }
}
