using System;

namespace DS
{
    class Program
    {
        static void Main(string[] args)
        {
            Arrays.StringManipulation a = new Arrays.StringManipulation();
            a.ReverseString("abc");

            Arrays.MergeSortedArray merge = new Arrays.MergeSortedArray();
            merge.MergeArray(new int[] { 1, 3, 5 }, new int[] { 2, 31, 45 });
        }
    }
}
