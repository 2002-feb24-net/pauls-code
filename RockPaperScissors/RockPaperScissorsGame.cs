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
            System.Console.Write("Round " + roundnumber + ". Enter r, p, or s: ");
            string player = Console.ReadLine();
            int computer = RandNum(1, 4);

            if (player == "r")
            {
                System.Console.WriteLine("You chose Rock");
                if(computer == 1)
                {
                    ties++;
                    System.Console.WriteLine("Computer chose Rock");
                    System.Console.WriteLine("It's a tie.");
                    System.Console.WriteLine();
                }
                else if (computer == 2)
                {
                    losses++;
                    System.Console.WriteLine("Computer chose Paper");
                    System.Console.WriteLine("You lose!");
                    System.Console.WriteLine();
                }
                else if (computer == 3)
                {
                    wins++;
                    System.Console.WriteLine("Computer chose Scissors");
                    System.Console.WriteLine("You win!");
                    System.Console.WriteLine();
                }
            }

            else if(player == "p")
            {
                System.Console.WriteLine("You chose Paper");
                if(computer == 1)
                {
                    wins++;
                    System.Console.WriteLine("Computer chose Rock");
                    System.Console.WriteLine("You win!");
                    System.Console.WriteLine();
                }
                else if (computer == 2)
                {
                    ties++;
                    System.Console.WriteLine("Computer chose Paper");
                    System.Console.WriteLine("It's a tie.");
                    System.Console.WriteLine();
                }
                else if (computer == 3)
                {
                    losses++;
                    System.Console.WriteLine("Computer chose Scissors");
                    System.Console.WriteLine("You lose!");
                    System.Console.WriteLine();
                }
            }

            else if(player == "s")
            {
                System.Console.WriteLine("You chose Scissors");
                if(computer == 1)
                {
                    losses++;
                    System.Console.WriteLine("Computer chose Rock");
                    System.Console.WriteLine("You lose!");
                    System.Console.WriteLine();
                }
                else if (computer == 2)
                {
                    wins++;
                    System.Console.WriteLine("Computer chose Paper");
                    System.Console.WriteLine("You win!");
                    System.Console.WriteLine();
                }
                else if (computer == 3)
                {
                    ties++;
                    System.Console.WriteLine("Computer chose Scissors");
                    System.Console.WriteLine("It's a tie.");
                    System.Console.WriteLine();
                }
            }
            else
            {
                System.Console.WriteLine("Please enter ONLY 'r', 'p', or 's' ");
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