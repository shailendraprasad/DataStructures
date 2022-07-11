using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    public class DynamicArray<T>
    {
        int capacity = 0;
        private T[] arr;
        int len = 0;

        public DynamicArray() : this(16)
        { }

        public DynamicArray(int capacity)
        {
            if (capacity < 0) throw new ArgumentException();
            this.capacity = capacity;
            arr = new T[capacity];
        }

        public int Size()
        {
            return len;
        }

        public T Get(int index)
        {
            if (index < 0 || index >= arr.Length) throw new ArgumentOutOfRangeException();
            return arr[index];
        }

        public void Set(int index, T element)
        {
            if (index < 0 || index >= arr.Length) throw new ArgumentOutOfRangeException();
            arr[index] = element;
        }

        public void Add(T elem)
        {
            if (len + 1 >= capacity)
            {
                if (capacity == 0) capacity = 1;
                else capacity *= 2;
                T[] newArr = new T[capacity];
                for (int i = 0; i < len; i++) newArr[i] = arr[i];
                arr = newArr;
            }

            arr[len++] = elem;
        }

        public T RemoveAt(int index)
        {
            var data = arr[index];
            T[] newArr = new T[len - 1];
            for (int i = 0, j = 0; i < len; i++, j++)
            {
                if (index == i) j--;
                else newArr[j] = arr[i];
            }
            arr = newArr;
            capacity = --len;
            return data;
        }

        public bool IsEmpty()
        {
            return Size() == 0;
        }

        public override string ToString()
        {
            if (len == 0) return "[]";
            else
            {
                StringBuilder sb = new StringBuilder(len).Append("[");
                for (int i = 0; i < len - 1; i++) sb.Append(arr[i] + ", ");
                return sb.Append(arr[len - 1] + "]").ToString();
            }
        }

    }
}

