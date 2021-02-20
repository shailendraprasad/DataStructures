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
            int[] arr = { 21, 9, 6, 67, 0, 4, 3, 2, -1, -99, 108, 77, 45, 66, 67, 95 };
            BubbleSort(arr);
            SelectionSort(arr);
            InsertionSort(arr);
            Console.WriteLine("Merge Sort: [{0}]", string.Join(", ", MergeSort(arr)));
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
                for (int j = 0; j < a.Length - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        var temp = a[j + 1];
                        a[j + 1] = a[j];
                        a[j] = temp;
                    }
                }

            }
            Console.WriteLine("Bubble Sort: [{0}]", string.Join(", ", a));
        }

        /// <summary>
        /// Selection Sort
        /// Find the minimum, check and swap with the lowest element in the array
        /// </summary>
        /// <param name="a"></param>
        public static void SelectionSort(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                int min = i;
                for (int j = i; j < a.Length; j++)
                {
                    if (a[j] < a[min])
                    {
                        min = j;
                    }
                }

                var temp = a[i];
                a[i] = a[min];
                a[min] = temp;

            }
            Console.WriteLine("Selection Sort:  [{0}]", string.Join(", ", a));
        }

        /// <summary>
        /// Insertion Sort
        /// Take a Marker in a new variable, swap all the smaller elements and then put in the place
        /// Combination of while and for
        /// </summary>
        /// <param name="a"></param>
        public static void InsertionSort(int[] a)
        {
            for (int i = 1; i < a.Length; i++)
            {
                int markerValue = a[i];
                int markerLocation = i;

                while (markerLocation > 0 && a[markerLocation - 1] > markerValue)
                {
                    a[markerLocation] = a[markerLocation - 1];
                    markerLocation = markerLocation - 1;
                }
                a[markerLocation] = markerValue;


            }
            Console.WriteLine("Insertion Sort: [{0}]", string.Join(", ", a));
        }



        /// <summary>
        /// Merge Sort
        /// Split the array to the lowest and merge them back
        /// </summary>
        /// <param name="a"></param>
        public static int[] MergeSort(int[] a)
        {
            if (a.Length == 1)
            {
                return a;
            }

            int MidValue = Math.Abs(a.Length / 2);
            int[] arrayOne = new int[MidValue];
            Array.Copy(a, 0, arrayOne, 0, MidValue);

            int[] arrayTwo = new int[a.Length - MidValue];
            Array.Copy(a, MidValue, arrayTwo, 0, a.Length - MidValue);

            MergeSort(arrayOne);
            MergeSort(arrayTwo);

            return CombineArray(arrayOne, arrayTwo);
        }

        /// <summary>
        /// Method to combine the array
        /// </summary>
        /// <param name="arrayOne"></param>
        /// <param name="arrayTwo"></param>
        /// <returns></returns>
        public static int[] CombineArray(int[] arrayOne, int[] arrayTwo)
        {
            int[] combinedArray = new int[arrayOne.Length + arrayTwo.Length];
            int j = 0;
            int i = 0;
            int mi = 0;

            //route through the first array and compare with array two
            //Based on the comparison value add in the combined array
            for (i = 0; i < arrayOne.Length && arrayTwo.Length >= j; i++)
            {
                if (arrayOne[i] > arrayTwo[j])
                {
                    combinedArray[mi] = arrayTwo[j];
                    j++;
                }
                else
                {
                    combinedArray[mi] = arrayOne[i];
                }
                mi++;
            }

            //add the remaining array in the combined array
            while (j < arrayTwo.Length)
            {
                combinedArray[mi] = arrayTwo[j];
                mi++;
                j++;
            }

            //add the remaining array in the combined array
            while (i < arrayOne.Length)
            {
                combinedArray[mi] = arrayOne[i];
                i++;
                mi++;
            }

            return combinedArray;
        }
    }
}
