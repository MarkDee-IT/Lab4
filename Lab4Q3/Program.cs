/* Name: Mark Dee
 * Decription: Take an int array into a method and return an array of 9s
 * Date: 08/02/2021
 */

using System;

namespace Lab4Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create array
            int[] arr = new int[5] { 1, 2, 3, 4, 5 };

            int[] ninesArray = AllTheNines(arr);

            Console.WriteLine("{0}, {1}, {2}, {3}, {4}", ninesArray[0], ninesArray[1], ninesArray[2], ninesArray[3], ninesArray[4]);
        }

        static int[] AllTheNines (int[] arr)
        {
            int[] ninesArray = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                ninesArray[i] = 9;
            }

            return ninesArray;
        }
    }
}
