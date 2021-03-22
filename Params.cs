using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Params
    {
        // The word params allows method take both types of arguments, like arrays or just row of integers
        public int Addition(params int[] integers)
        {
            int result = 0;

            for (int i = 0; i < integers.Length; i++)
            {
                result += integers[i];
            }
            return result;
        }
    }
}
