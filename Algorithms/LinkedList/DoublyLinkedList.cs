using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.LinkedList
{
    public class DoublyLinkedList<T>
    {
        private DoublyNode<T>     head;       // первый элемент
        private DoublyNode<T>     tail;       // последний элемент
        private int               length;     // кол-во элементов

        public void Add(T data)
        {
            DoublyNode<T> temp = new DoublyNode<T>(data);

            if (head == null)
                head = temp;
            else
            {
                tail.Next = temp;
                temp.Prev = tail;
            } 
            tail = temp;
            length += 1;
        }

        public void AddHead(T data)
        {
            DoublyNode<T> temp = new DoublyNode<T>(data);

            if (head == null)
                tail = temp;
            else
            {
                temp.Next = head;
                head.Prev = temp;
            }
            head = temp;
            length++;
        }

        public void AddTail(T data)         // checkt it!
        {
            if (head == null)
                AddHead(data);
            else
            {
                DoublyNode<T> temp = new DoublyNode<T>(data);
                tail.Next = temp;
                temp.Prev = tail;
                tail = temp;
                length += 1;
            }
        }

        public bool Contains(T data)
        {
            DoublyNode<T> current = head;

            while (current != null)
            {
                if (current.Data.Equals(data))
                    return true;
                current = current.Next;
            }
            return false;
        }

        public void InsertBefore(T beforeEl, T addElement)
        {
            if (Contains(beforeEl))
            {
                DoublyNode<T> current = head;
                DoublyNode<T> temp = new DoublyNode<T>(addElement);
                
                while (current != null)
                {
                    if (current.Data.Equals(beforeEl))
                    {
                        if (current.Prev == null)
                        {
                            AddHead(addElement);
                            current = null;
                        }
                        else
                        {
                            temp.Next = current;
                            temp.Prev = current.Prev;
                            current.Prev = temp;
                            temp.Prev.Next = temp;

                            current = null;
                            length++;
                        }
                    }
                    else
                        current = current.Next;
                }
            }
            else
                AddHead(addElement);
        }

        public void InsertAfter(T afterEl, T addElement)    // check it!
        {
            if (Contains(afterEl))
            {
                DoublyNode<T> current = head;
                DoublyNode<T> temp = new DoublyNode<T>(addElement);
                
                while (current != null)
                {
                    if (current.Next == null)
                    {
                        AddTail(addElement);
                        current = null;
                    }
                    else if (current.Data.Equals(afterEl))
                    {
                        temp.Next = current.Next;
                        temp.Next.Prev = temp;
                        current.Next = temp;
                        temp.Prev = current;

                        current = null;
                        length += 1;
                    }
                    else
                        current = current.Next;
                }
            }
            else
                AddTail(addElement);
        }

        public void Remove(T data)
        {
            DoublyNode<T> current = head;

            while (current != null)
            {
                if (current.Data.Equals(data))
                    break;
                current = current.Next;
            }

            if (current != null)
            {
                if (current.Next != null)
                    current.Next.Prev = current.Prev;
                else
                    tail = current.Prev;
                if (current.Prev != null)
                    current.Prev.Next = current.Next;
                else
                    head = current.Next;
                length -=1;
            }
        }

        public void RemoveHead()    // check it!
        {
            if (Length <= 0)
                return;

            head = head.Next;
            head.Prev = null;
            if (head == null)
                tail = null;
            length -= 1;
        }

        public void RemoveTail()
        {
            if (Length <= 0)
                return;

            tail = tail.Prev;
            tail.Next = null;
            length -= 1;

            if (tail == null)
                head = null;
        }

        public void RemoveByIndex(int i)
        {
            DoublyNode<T> current = head;
            int j = -1;

            while (current != null)
            {
                j += 1;

                if (i == 0)
                {
                    RemoveHead();
                    current = null;
                }
                else if (i == Length - 1)
                {
                    RemoveTail();
                    current = null;
                }
                else if (j == i)
                {
                    current.Prev.Next = current.Next;
                    current.Next.Prev = current.Prev;

                    current = null;
                    length -= 1;
                }
                else
                    current = current.Next;
            }
        }


        public int Length { get { return length; } }
        public bool IsEmpty { get { return length == 0; } }

        public void Clear()
        {
            head = null;
            tail = null;
            length = 0;
        }

        public T this[int _position]
        {
            get
            {
                DoublyNode<T> temp = this.head;
                for (int i = 0; i < _position; ++i)
                    temp = temp.Next;
                return temp.Data;
            }
        }

        public int GetIndex(T data)
        {
            DoublyNode<T> current = head;
            int i = -1;

            while (current != null)
            {
                i += 1;
                if (current.Data.Equals(data))
                    return i;
                else
                    current = current.Next;
            }
            return -1;
        }

        public void ViewFromHead()
        {
            for (int i = 0; i < this.Length; i++)
            {
                Console.Write(this[i] + " ");
            }
            Console.WriteLine();
        }

        public void ViewFromTail()
        {
            for (int i = this.Length - 1; i > -1; i--)
                Console.Write(this[i] + " ");
            Console.WriteLine();
        }
    }
}
