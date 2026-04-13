using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] student =
{
    { 75, 82, 90, 88 },
    { 60, 70, 65, 80 },
    { 95, 92, 88, 97 }
};

            for (int row = 0; row < student.GetLength(0); row++)
            {
                int total = 0;

                Console.Write("Student " + row + ": ");

                for (int col = 0; col < student.GetLength(1); col++)
                {
                    Console.Write(student[row, col] + " ");
                    total = total + student[row, col];
                }

                double average = (double)total / student.GetLength(1);
                Console.WriteLine("| Average: " + average.ToString("F2"));
            }
        }
    }
}
