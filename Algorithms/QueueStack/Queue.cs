using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.QueueStack
{
    /// <summary>
    /// CHECK ITTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Queue<T>
    {
        public int Length { get; private set; }
        private DoublyNode<T> head;
        private DoublyNode<T> tail;

        public Queue()
        {
            tail = head = null;
            Length = 0;
        }

        /// <summary>
        /// Добавление элемента в конец очереди
        /// </summary>
        public void Enqueue(T element)
        {
            if (head == null)
            {
                DoublyNode<T> _current = new DoublyNode<T>(element);
                tail = _current;
                head = _current;
                Length++;
            }
            else
            {
                DoublyNode<T> newNode = new DoublyNode<T>(element);
                tail.Next = newNode;
                newNode.Prev = tail;
                tail = newNode;
                Length++;
            }
        }

        /// <summary>
        /// Изъятие первого элемента
        /// </summary>
        public DoublyNode<T> Dequeue()
        {
            var ans = head;
            if (head == null)
                return null;
            head = head.Next;
            if (head != null)
                head.Prev = null;
            else
                tail = null;

            Length--;
            return ans;

        }

        /// <summary>
        /// Получение элемента из начала очереди
        /// </summary>
        public DoublyNode<T> Peek()
        {
            return head;
        }

        /// <summary>
        /// Вывод очереди
        /// </summary>
        public void View()
        {
            var curNode = Peek();

            if (curNode == null)
                return;

            while (curNode != null)
            {
                Console.Write(curNode.Data + " ");
                curNode = curNode.Next;
            }

            Console.WriteLine();
        }
    }
}
