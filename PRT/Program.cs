using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prallel_arrays_practice_problem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] productNames ={"Running Shoes","Soccer Ball", "Swim Googles", "Tennies Racket", "Yoga Mat"};
            double[] price = { 499.99, 149.99, 89.99, 349.99, 199.99 };
            int[] quantity = { 10, 25, 15, 8, 20 };



            for (int i = 0; i < quantity.Length; i++) 
            {
                Console.Write("Product:  |" + productNames[i] + " Price:  |" + price[i] +  "Quantity: |" + quantity[i]);
            }
        }
    }
}
