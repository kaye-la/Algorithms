using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.QueueStack
{
    /// <summary>
    /// CHECKKKKKKKKKKKK ITTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Stack<T>
    {
        public int Length { get; private set; }
        private DoublyNode<T> top;

        public Stack()
        {
            top = null;
            Length = 0;
        }

        /// <summary>
        /// Добавление элемента в конец стека
        /// </summary>
        public void Push(T element)
        {
            if (top == null)
            {
                top = new DoublyNode<T>(element);
                Length++;
            }
            else
            {
                top.Next = new DoublyNode<T>(element);
                top.Next.Prev = top;
                top = top.Next;
                Length++;
            }
        }

        /// <summary>
        /// Изъятие элемента из конца стека
        /// </summary>
        public DoublyNode<T> Pop()
        {
            var ans = top;

            if (top == null)
                return null;

            top = top.Prev;

            if (top != null)
                top.Next = null;
            else
                top = null;

            Length--;
            return ans;
        }

        /// <summary>
        /// Получение последнего элемента
        /// </summary>
        public DoublyNode<T> Peek()
        {
            return top;
        }

        /// <summary>
        /// Вывод стека
        /// </summary>
        public void View()
        {
            var curNode = Peek();

            if (curNode == null)
                return;

            while (curNode != null)
            {
                Console.Write(curNode.Data + " ");
                curNode = curNode.Prev;
            }

            Console.WriteLine();
        }
    }
}
