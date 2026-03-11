using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical2_PRT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows, columns;
            int rowSum, columnSum;

            Console.WriteLine("Enter number of rows:");
            rows = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number of columns:");
            columns = int.Parse(Console.ReadLine());

            int[,] numbers = new int[rows, columns];

            // Fill the array

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    Console.WriteLine("Enter a number for row " + r + " and column " + c);
                    numbers[r, c] = int.Parse(Console.ReadLine());
                }
            }

            // Display the array

            Console.WriteLine("\nArray:");

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    Console.Write(numbers[r, c] + " ");
                }
                Console.WriteLine();
            }

            // Row sums

            for (int r = 0; r < rows; r++)
            {
                rowSum = 0;

                for (int c = 0; c < columns; c++)
                {
                    rowSum += numbers[r, c];
                }

                Console.WriteLine("The sum of row " + r + " is " + rowSum);
            }

            // Column sums

            for (int c = 0; c < columns; c++)
            {
                columnSum = 0;

                for (int r = 0; r < rows; r++)
                {
                    columnSum += numbers[r, c];
                }

                Console.WriteLine("The sum of column " + c + " is " + columnSum);
            }

            Console.ReadLine();
        }
    }

}
