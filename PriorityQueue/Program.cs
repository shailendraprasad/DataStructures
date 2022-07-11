using System.Collections;

namespace PriorityQueue
{
    public class BinaryHeap<T> where T : IComparable
    {
        private ArrayList heap;

        public BinaryHeap(): this(1)
        {
            
        }

        public BinaryHeap(int size)
        {
            heap = new ArrayList(size);
        }

        public BinaryHeap(T[] elems)
        {
            int heapSize = elems.Length;
            heap = new ArrayList(heapSize);

            // Place all element in heap
            for (int i = 0; i < heapSize; i++) heap.Add(elems[i]);

            // Heapify process, O(n)
            for (int i = Math.Max(0, (heapSize / 2) - 1); i >= 0; i--) sink(i);
        }

        public int size()
        {
            return heap.Count;
        }

        private void sink(int k)
        {
            int heapSize = size();
            while (true)
            {
                int left = 2 * k + 1; // Left  node
                int right = 2 * k + 2; // Right node
                int smallest = left; // Assume left is the smallest node of the two children

                // Find which is smaller left or right
                // If right is smaller set smallest to be right
                if (right < heapSize && less(right, left)) smallest = right;

                // Stop if we're outside the bounds of the tree
                // or stop early if we cannot sink k anymore
                if (left >= heapSize || less(k, smallest)) break;

                // Move down the tree following the smallest node
                swap(smallest, k);
                k = smallest;
            }

        }

        private bool less(int i, int j)
        {
            T node1 = (T)heap[i];
            T node2 = (T)heap[j];
            return node1.CompareTo(node2) <= 0;
        }

        private void swap(int i, int j)
        {
            T elem_i = (T)heap[i];
            T elem_j = (T)heap[j];

            heap[i] = elem_j;
            heap[j] = elem_i;
        }

    }

    public class Test
    {
        public static void Main(string [] args)
        {
            int[] arr = new int[] { 3, 7, 3, 4, 5, 6, 7 };
            new BinaryHeap<int>(arr);
        }
    }
}