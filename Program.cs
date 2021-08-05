using System;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WelCome to Snake And Ladder Game!");
            int playerreaches = 0;
            int DiceRolled = 0;

            Random rand = new Random();
            while (playerreaches! <= 100)
            {
                int DiceRoll = rand.Next(1, 7);
                int PositionCheck = rand.Next(0, 3);
                Console.WriteLine(DiceRoll);

                switch (PositionCheck)
                {
                    case 0:
                        Console.WriteLine("No Play Player remains at same position");
                        Console.WriteLine("playerreached" + playerreaches);
                        DiceRolled++;
                        break;
                    case 1:
                        Console.WriteLine("Player Moves ahead");
                        playerreaches += DiceRoll;
                        Console.WriteLine("playerreached" + playerreaches);
                        DiceRolled++;
                        break;
                    case 2:
                        Console.WriteLine("Player moves behind");
                        playerreaches -= DiceRoll;
                        Console.WriteLine("playerreached" + playerreaches);
                        DiceRolled++;
                        if (playerreaches < 0)
                        {
                            playerreaches = 0;
                        }
                        break;

                }
            }
            Console.WriteLine("Playerwon " + playerreaches);
            Console.WriteLine("TotalNoOfDiceRolled " + DiceRolled);
        }
    }

}