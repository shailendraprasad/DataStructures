using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS
{
    public class LinkedListExecute
    {
        public static void Main(string[] args)
        {
            LinkedList<int> intList = new LinkedList<int>();
            intList.add(5);
            intList.add(20);
            Console.WriteLine(intList.ToString());
        }
    }

    //Doubly linked list
    public class LinkedList<T>
    {
        private Node<T> head;
        private Node<T> tail;
        private int size = 0;

        private class Node<T>
        {
            public T data;
            public Node<T> prev, next;

            public Node(T data, Node<T> prev, Node<T> next)
            {
                this.data = data;
                this.prev = prev;
                this.next = next;
            }

            public override string ToString()
            {
                return data.ToString();
            }
        }

        public int Size()
        {
            return size;
        }

        public bool IsEmpty()
        {
            return Size() == 0;
        }

        public void add(T elem)
        {
            addLast(elem);
        }

        private void addLast(T elem)
        {
            if (IsEmpty())
            {
                head = tail = new Node<T>(elem, null, null);
            }
            else
            {
                tail.next = new Node<T>(elem, tail, null);
                tail = tail.next;
            }
            size++;
        }

        private void addFirst(T elem)
        {
            if (IsEmpty())
            {
                head = tail = new Node<T>(elem, null, null);
            }
            else
            {
                head.prev = new Node<T>(elem, null, head);
                head = head.prev;
            }
            size++;

        }

        public void addAt(int index, T data)
        {
            if (index < 0 || index > size)
            {
                throw new Exception("Illegal Index");
            }
            if (index == 0)
            {
                addFirst(data);
                return;
            }

            if (index == size)
            {
                addLast(data);
                return;
            }

            Node<T> temp = head;
            for (int i = 0; i < index-1; i++)
            {
                temp = temp.next;
            }
            Node<T> newNode = new Node<T>(data, temp, temp.next);
            temp.next.prev = newNode;
            temp.next = newNode;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[ ");
            Node<T> trav = head;
            while(trav != null)
            {
                sb.Append(trav.data);
                if (trav.next != null)
                {
                    sb.Append(", ");
                }
                trav = trav.next;
            }
            sb.Append(" ]");
            return sb.ToString();
        }
    }
}
