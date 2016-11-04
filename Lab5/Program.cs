using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("How many sides do these die have?");
                int sides;
                int dice1;
                int dice2;
                while (!int.TryParse(Console.ReadLine(), out sides))
                {
                    Console.WriteLine("Please input a correct value.");
                }
                rollDice(sides, out dice1, out dice2);
                Console.WriteLine($"Your first roll was: {dice1}, Your second roll was: {dice2}");
                specialMessage(dice1, dice2);
                Console.WriteLine("Enter y or Y if you want to continue.");
                string answer = Console.ReadLine();
                if (!(answer == "Y" || answer == "y"))
                    break;
            }
        }
        static void rollDice( int sides, out int roll1, out int roll2)
        {   
            Random r1 = new Random(DateTime.Now.Millisecond);
            roll1 = r1.Next(1, sides);
            roll2 = r1.Next(1, sides);
        }
        static void specialMessage(int roll1, int roll2)
        {
            if (roll1 == 6 && roll2 == 6)
            {
                Console.WriteLine("Boxcars!");
            }
            else if (roll1 == 1 && roll2 == 1)
            {
                Console.WriteLine("Snake Eyes!");
            }
            else if ((roll1 == 7 && roll2 == 11) || (roll2 == 7 && roll2 == 11))
            {
                Console.WriteLine("Craps!");
            }
        }
    }
}
