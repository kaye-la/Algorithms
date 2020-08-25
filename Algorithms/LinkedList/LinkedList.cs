using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.LinkedList
{
    public class LinkedList<T>
    {
        private Node<T>     head;       // первый элемент
        private Node<T>     tail;       // последний элемент
        private int         length;     // кол-во элементов
        
        public void Add(T data)
        {
            Node<T> temp = new Node<T>(data);

            if (head == null)
                head = temp;
            else
                tail.Next = temp;
            tail = temp;
            length += 1;
        }

        public void AddHead(T data)
        {
            Node<T> temp = new Node<T>(data);
            temp.Next = head;
            head = temp;

            if (length == 0)
                tail = temp;
            length += 1;
        }

        public void AddTail(T data)
        {
            if (head == null)
                AddHead(data);
            else
            {
                Node<T> temp = new Node<T>(data);
                tail.Next = temp;
                tail = temp;
                length += 1;
            }
        }

        public Node<T> GetPrevNode(Node<T> current)
        {
            Node<T> temp = head;

            if (temp == current)
                return null;

            while (temp.Next != current)
            {
                temp = temp.Next;
            }
            return temp;
        }

        public bool Contains(T data)
        {
            Node<T> current = head;

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
                Node<T> current = head;
                Node<T> temp = new Node<T>(addElement);

                while (current != null)
                {
                    if (current.Data.Equals(beforeEl))
                    {
                        temp.Next = current;
                        if (GetPrevNode(current) == null)
                        {
                            AddHead(addElement);
                            current = null;
                        }
                        else
                        {
                            GetPrevNode(current).Next = temp; // check it!
                            current = null;
                        }
                        length += 1;
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
                Node<T> current = head;
                Node<T> temp = new Node<T>(addElement);

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
                        current.Next = temp;
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

        public bool Remove(T data)
        {
            Node<T> current = head;
            Node<T> previous = null;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;

                        if (current.Next == null)
                            tail = previous;
                    }
                    else
                    {
                        head = head.Next;

                        if (head == null)
                            tail = null;
                    }
                    length -= 1;
                    return true;
                }
                previous = current;
                current = current.Next;
            }
            return false;
        }

        public void RemoveHead()    // check it!
        {
            if (Length <= 0)
                return ;

            head = head.Next;
            length -= 1;

            if (head == null)
                tail = null;
        }

        public void RemoveTail()
        {
            if (Length <= 0)
                return;

            tail = GetPrevNode(tail);
            tail.Next = null;
            length -= 1;

            if (tail == null)
                head = null;
        }

        public void RemoveByIndex(int i)
        {
            Node<T> current = head;
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
                    GetPrevNode(current).Next = current.Next;
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
                Node<T> temp = this.head;
                for (int i = 0; i < _position; ++i)
                    temp = temp.Next;
                return temp.Data;
            }
        }

        public int GetIndex(T data)
        {
            Node<T> current = head;
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
