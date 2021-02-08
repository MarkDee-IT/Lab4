/* Name: Mark Dee
 * Decription: Check cost of product with a given product code
 * Date: 08/02/2021
 */

using System;

namespace Lab4Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Import encoding
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Set variables
            decimal cost;
            string productCode;

            Console.Write("Please enter product code :   ");
            productCode = Console.ReadLine().ToUpper();

            cost = ProductCost(productCode);

            if (cost == -999)
            {
                Console.WriteLine("ERROR: INVALID PRODUCT CODE");
                return;
            }

            Console.WriteLine("Cost of order is {0:c}", cost);

        }

        static decimal ProductCost(string code)
        {
            // Set result variable
            decimal result = 0;

            // Switch statement
            switch (code)
            {
                case "ABC":
                    result = 10.10m;
                    break;

                case "XYZ":
                    result = 69.32m;
                    break;

                case "FR45":
                    result = 34.00m;
                    break;

                case "S34":
                case "G65":
                case "F34":
                    result = 5.00m;
                    break;

                default:
                    result = -999m;
                    break;
            }

            return result;
        }
    }
}
