using System;

namespace Daily_Coding_Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given an array of integers, 
             * return a new array such that each element at index i of the new array 
             * is the product of all the numbers in the original array except the one at i.
             * For example, if our input was [1, 2, 3, 4, 5], 
             * the expected output would be [120, 60, 40, 30, 24]. 
             * If our input was [3, 2, 1], the expected output would be [2, 3, 6].
             */
            int[] Array = new int[] { 1, 2, 3, 4, 5 };
            foreach (int number in Function(Array))
            {
                Console.Write("["+number+"]" + " ");
            }
        }
        static int[] Function(int[] array)
        {
            int[] exitArray = new int[array.Length];
            int product = 1;
            for(int Position = 0; Position < array.Length; Position++)
            {
                product *= array[Position];
            }
            for (int Position = 0; Position < array.Length; Position++)
            {
                exitArray[Position] = product / array[Position];
            }
            return exitArray;
        }
    }
}
