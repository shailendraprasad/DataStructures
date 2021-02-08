using System;
using System.Collections.Generic;
using System.Text;

namespace DS.Arrays
{
    public class StringManipulation
    {
        public void ReverseString(string s)
        {
            string rev = null;
            var array = s.ToCharArray();
            for(int i  = array.Length; i > 0; i--)
            {
                rev += array[i - 1];
            }
        }
    }
}
