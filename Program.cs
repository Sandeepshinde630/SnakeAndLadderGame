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
            int PositionCheck = rand.Next(0, 3);
            switch (PositionCheck)
            {
                case 0:
                    Console.WriteLine("No Play Player remains at same position");
                   break;
                case 1:
                    Console.WriteLine("Player Moves ahead");
                    break;
                case 2:
                    Console.WriteLine("Player moves behind");
                    break;

            }
        }
    }

}