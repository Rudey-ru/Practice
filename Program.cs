using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            // You can call any method in this solutionl, for example I call SortApp

            int[] arr = new int[] { 4, 3, 76, -3, -1, 0, 2, 1, 199 };

            foreach (int i in BubbleSort.SortApp(arr))
            {
                Console.Write(i + " ");
            } 

        }
    }
}

      
