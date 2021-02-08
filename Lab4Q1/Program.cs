/* Name: Mark Dee
 * Decription: Check if users 18 to 21 can use a service
 * Date: 08/02/2021
 */

using System;

namespace Lab4Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test cases
            int age1 = 21;
            int age2 = 18;
            int age3 = 16;
            int age4 = 20;
            int age5 = 25;

            // Check the cases
            bool case1 = CheckAge(age1);
            bool case2 = CheckAge(age2);
            bool case3 = CheckAge(age3);
            bool case4 = CheckAge(age4);
            bool case5 = CheckAge(age5);

            Console.WriteLine("{0}, {1}\n{2}, {3}\n{4}, {5}\n{6}, {7}\n{8}, {9}", age1, case1, age2, case2, age3, case3, age4, case4, age5, case5);
        }

        static bool CheckAge (int age)
        {
            if (age <= 21 && age >= 18)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
