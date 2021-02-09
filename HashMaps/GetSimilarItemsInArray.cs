using System;
using System.Collections.Generic;
using System.Text;

namespace HashMaps
{
    public class GetSimilarItemsInArray
    {
        public void GetFirstRecurringCharacter(int[] array1)
        {
            Dictionary<int, int> keyValues = new Dictionary<int, int>();
            for (int i = 0; i < array1.Length; i++)
            {
                int val;
                if(keyValues.TryGetValue(array1[i], out val)){
                    Console.WriteLine($"Recurring character is {val}");
                    break;
                }
                else{
                    keyValues.Add(array1[i], array1[i]);
                }
                i++;
            }
        }
    }
}
