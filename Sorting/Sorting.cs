using System;

namespace Sorting
{
    /// <summary>
    /// Practise Sorting
    /// </summary>
    class Sorting
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sorting");
            int [] arr = { 21, 9, 6, 67, 0, 4, 3, 2 };
            BubbleSort(arr);
        }

        /// <summary>
        /// Bubble Sort 
        /// Compare one with the next one and swap if greater
        /// Do this for all the items in the array
        /// </summary>
        /// <param name="a"></param>
        public static void BubbleSort(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length-1; j++)
                {
                    if(a[j] > a[j+1])
                    {
                        var temp = a[j + 1];
                        a[j + 1] = a[j];
                        a[j] = temp;
                    }
                }

            }
            Console.WriteLine("[{0}]", string.Join(", ", a));
        }

       
    }
}
