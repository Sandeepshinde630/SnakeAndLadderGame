using System;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WelCome to Snake And Ladder Game!");
            int playerreaches = 0;
            Random rand = new Random();
            int DiceRoll = rand.Next(1, 7);
            Console.WriteLine(DiceRoll);

        }
    }

}