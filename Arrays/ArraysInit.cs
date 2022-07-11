using System;

namespace Arrays
{
    class ArraysInit
    {
        static void Main(string[] args)
        {
            Arrays.StringManipulation a = new Arrays.StringManipulation();
            a.ReverseString("abc");

            Arrays.MergeSortedArray merge = new Arrays.MergeSortedArray();
            merge.MergeArray(new int[] { 1, 3, 5 }, new int[] { 2, 31, 45 });

            DynamicArray<int> array = new DynamicArray<int>();
            array.Add(1);
            array.Add(15);
            array.Add(9);
            Console.WriteLine(array.RemoveAt(1));
            Console.WriteLine(array.ToString());
        }
    }
}
