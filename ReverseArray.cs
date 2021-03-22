using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class ReverseArray
    {   
        static public int[] Reverse(int[] arr)
        {
            int n = arr.Length; 
            int k = n / 2;          
            int temp;

            for (int i = 0; i < k; i++)
            {
                temp = arr[i];
                arr[i] = arr[n - i - 1];
                arr[n - i - 1] = temp;
            }

            return arr;
        }
    }
}
