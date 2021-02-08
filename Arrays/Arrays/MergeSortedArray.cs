using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    public class MergeSortedArray
    {
        /// <summary>
        /// Merging already sorted Array
        /// </summary>
        /// <param name="array1"></param>
        /// <param name="array2"></param>
        public void MergeArray(int[] array1, int[] array2)
        {
            int[] mergedArray = new int[array1.Length + array2.Length];
            int acount = 0;
            int i = 0;
            int j = 0;
            while (i + j != array1.Length + array2.Length)
            {
                if (i < array1.Length && array1[i] < array2[j])
                {
                    mergedArray[acount] = array1[i];
                    i++;
                    acount++;
                }
                else if (j < array2.Length)
                {
                    mergedArray[acount] = array2[j];
                    j++;
                    acount++;
                }
            }
            Console.WriteLine(mergedArray);
        }
    }
}
