using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            RockPaperScissorsGame game = new RockPaperScissorsGame();

            bool readyToQuit = false;

            while (!readyToQuit)
            {
                System.Console.WriteLine("SHALL WE PLAY A GAME?");
                string input = Console.ReadLine();
                System.Console.WriteLine();

                if (input == "n" )
                {
                    readyToQuit = true;
                }
                else if (input == "Love to. How about Global Thermonuclear War?")  //Easter egg
                {
                    System.Console.WriteLine("WOULDN'T YOU PREFER A GOOD GAME OF CHESS?");
                    break;
                }
                else
                {
                    game.PlayRound();  // that method should play a round and print a result
                }
            }

            game.PrintSummary();  // that method should print out a summary of the rounds. 
        }
    }
}
