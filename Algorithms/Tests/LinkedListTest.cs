using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Tests
{
    public class LinkedListTest
    {
        public static void run()
        {
            #region Linked List Test
            Console.WriteLine("\n----------------Linked List Test-----------------");

            Algorithms.LinkedList.LinkedList<int> linkedList = new Algorithms.LinkedList.LinkedList<int>();
            linkedList.Add(1);
            linkedList.Add(2);
            linkedList.Add(3);

            Console.Write("Initial Linked List: ");
            linkedList.ViewFromHead();

            linkedList.Remove(2);
            Console.Write("Linked list after removing 2: ");
            linkedList.ViewFromHead();

            linkedList.InsertBefore(3, 79);
            Console.Write("Linked list after inserting 79 before 3: ");
            linkedList.ViewFromHead();

            linkedList.InsertAfter(3, 75);
            Console.Write("Linked list after inserting 75 after 3: ");
            linkedList.ViewFromHead();

            linkedList.RemoveByIndex(2);
            Console.Write("Linked list after removing by index[2]: ");
            linkedList.ViewFromHead();

            linkedList.RemoveTail();
            Console.Write("Linked list after removing tail: ");
            linkedList.ViewFromHead();

            linkedList.AddHead(20);
            Console.Write("Linked list after adding head 20: ");
            linkedList.ViewFromHead();
            #endregion

            #region Doubly Linked List Test
            Console.WriteLine("\n----------------Doubly Linked List Test-----------------");

            Algorithms.LinkedList.DoublyLinkedList<int> doublyLinkedList = new Algorithms.LinkedList.DoublyLinkedList<int>();
            doublyLinkedList.Add(1);
            doublyLinkedList.Add(2);
            doublyLinkedList.Add(3);

            Console.Write("Initial Linked List: ");
            doublyLinkedList.ViewFromHead();

            doublyLinkedList.Remove(2);
            Console.Write("Linked list after removing 2: ");
            doublyLinkedList.ViewFromHead();

            doublyLinkedList.InsertBefore(3, 79);
            Console.Write("Linked list after inserting 79 before 3: ");
            doublyLinkedList.ViewFromHead();

            doublyLinkedList.InsertAfter(3, 75);
            Console.Write("Linked list after inserting 75 after 3: ");
            doublyLinkedList.ViewFromHead();

            doublyLinkedList.RemoveByIndex(2);
            Console.Write("Linked list after removing by index[2]: ");
            doublyLinkedList.ViewFromHead();

            doublyLinkedList.RemoveTail();
            Console.Write("Linked list after removing tail: ");
            doublyLinkedList.ViewFromHead();

            doublyLinkedList.AddHead(20);
            Console.Write("Linked list after adding head 20: ");
            doublyLinkedList.ViewFromHead();
            #endregion
        }
    }
}
