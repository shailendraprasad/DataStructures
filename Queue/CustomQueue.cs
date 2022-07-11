using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class CustomQueue<T>
    {
        LinkedList<T> queue=new LinkedList<T>();

        public void Enqueue(T item)
        {
            queue.AddLast(item);
        }
        public void Dequeue()
        {
            queue.RemoveFirst();
        }
        public int Size()
        {
            return queue.Count;
        }
    }
}
