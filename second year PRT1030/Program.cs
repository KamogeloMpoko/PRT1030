using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRT_Practical_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = 0;
            int repeat = 0;

            Console.WriteLine("Please enter the number of lines: ");
            lines = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the number of times to repeat: ");
            repeat = int.Parse(Console.ReadLine());

            for (int r = 1; r <= repeat; r++)          // Repeat image
            {
                for (int i = 1; i <= lines; i++)       // Lines
                {
                    for (int j = 1; j <= i; j++)       // Stars per line
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
