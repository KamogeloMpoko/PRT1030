using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRT_IF_Statement_prac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 25;
            int TicketPrice;


            if (age <= 4)
            {
                TicketPrice = 0;
            }
            else if (age >= 5 && age <= 12)
            {
                TicketPrice = 50;
            }
            else if (age >= 13 && age <= 17)
            {   
                TicketPrice = 80;
            }
            else if (age >= 18 && age <= 64)
            {
                TicketPrice = 120;
            }
            else
            {
                TicketPrice = 60;
            }


            Console.Write("Ticket price : {0:c}"+  TicketPrice);
        }
    }
}
