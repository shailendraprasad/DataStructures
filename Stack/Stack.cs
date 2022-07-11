using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class CustomStack<T>
    {
        public LinkedList<T> list = new LinkedList<T> ();

        public void Push(T item)
        {
            list.AddLast(item);
        }

        public void Pop()
        {
            list.RemoveLast();
        }

        public int Size()
        {
            return list.Count;
        }

        public bool isEmpty()
        {
            return Size() == 0;
        }

        public T Peek()
        {
            return list.FirstOrDefault();
        }
    }
}
