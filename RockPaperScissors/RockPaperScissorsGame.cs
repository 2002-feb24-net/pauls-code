using System;

namespace RockPaperScissors
{
    class RockPaperScissorsGame
    {
        int wins = 0;

        int losses = 0;

        int ties = 0;

        int roundnumber = 1;

        public void PlayRound()
        {
            System.Console.Write("Round " + roundnumber + ", Enter r, p, or s: ");
            string player = Console.ReadLine();
            int computer = RandNum(1, 4);

            if (computer == 1)
            {
                System.Console.WriteLine("computer plays Rock");
                if(player == "r")
                {
                    ties++;
                    System.Console.WriteLine("It's a tie.");
                    System.Console.WriteLine();
                }
                else if (player == "p")
                {
                    wins++;
                    System.Console.WriteLine("You win!");
                    System.Console.WriteLine();
                }
                else if (player == "s")
                {
                    losses++;
                    System.Console.WriteLine("You lose!");
                    System.Console.WriteLine();
                }
            }

            else if(computer == 2)
            {
                System.Console.WriteLine("computer plays Paper");
                if(player == "r")
                {
                    losses++;
                    System.Console.WriteLine("You lose!");
                    System.Console.WriteLine();
                }
                else if (player == "p")
                {
                    ties++;
                    System.Console.WriteLine("It's a tie.");
                    System.Console.WriteLine();
                }
                else if (player == "s")
                {
                    wins++;
                    System.Console.WriteLine("You win!");
                    System.Console.WriteLine();
                }
            }

            else if(computer == 3)
            {
                System.Console.WriteLine("computer plays Scissors");
                if(player == "r")
                {
                    wins++;
                    System.Console.WriteLine("You win!");
                    System.Console.WriteLine();
                }
                else if (player == "p")
                {
                    losses++;
                    System.Console.WriteLine("You lose!");
                    System.Console.WriteLine();
                }
                else if (player == "s")
                {
                    ties++;
                    System.Console.WriteLine("It's a tie.");
                    System.Console.WriteLine();
                }
            }

            roundnumber++;
        }

        public void PrintSummary()
        {
            System.Console.WriteLine("Wins: " + wins);
            System.Console.WriteLine("Losses: " + losses);
            System.Console.WriteLine("Ties: " + ties);
        }

        int RandNum(int min, int max)   // Generate a random number between two numbers  
        {                               // includes the first number, excludes the second
            var rand = new Random();  
            return rand.Next(min, max);  
        }

    }
}