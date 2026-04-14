using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Dice_picker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] dice = new int[2];
            int totalRolls = 0;

            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = random.Next(1, 7);
                Console.WriteLine("Dice " + (i + 1) + ": " + dice[i]);
            }

            if (dice[0] == dice[1])
            {
                Console.WriteLine("You rolled a double! Both dice show: " + dice[0]);
            }
            else
            {
                Console.WriteLine("You rolled: " + dice[0] + " and " + dice[1]);
            }

            totalRolls = dice[0] + dice[1];
            Console.WriteLine("Total: " + totalRolls);


        }
    }

}
