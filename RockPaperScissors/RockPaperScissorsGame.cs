using System;
using System.Collections.Generic;

namespace RockPaperScissors
{
    class RockPaperScissorsGame
    {
        int wins = 0;

        int losses = 0;

        int ties = 0;

        int roundnumber = 1;

        List<string> roundResults = new List<string>();
        
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
                    roundResults.Add("Tie");
                    System.Console.WriteLine("Computer chose Rock");
                    System.Console.WriteLine("It's a tie.");
                    System.Console.WriteLine();
                }
                else if (computer == 2)
                {
                    losses++;
                    roundResults.Add("Loss");
                    System.Console.WriteLine("Computer chose Paper");
                    System.Console.WriteLine("You lose!");
                    System.Console.WriteLine();
                }
                else if (computer == 3)
                {
                    wins++;
                    roundResults.Add("Win");
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
                    roundResults.Add("Win");
                    System.Console.WriteLine("Computer chose Rock");
                    System.Console.WriteLine("You win!");
                    System.Console.WriteLine();
                }
                else if (computer == 2)
                {
                    ties++;
                    roundResults.Add("Tie");
                    System.Console.WriteLine("Computer chose Paper");
                    System.Console.WriteLine("It's a tie.");
                    System.Console.WriteLine();
                }
                else if (computer == 3)
                {
                    losses++;
                    roundResults.Add("Loss");
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
                    roundResults.Add("Loss");
                    System.Console.WriteLine("Computer chose Rock");
                    System.Console.WriteLine("You lose!");
                    System.Console.WriteLine();
                }
                else if (computer == 2)
                {
                    wins++;
                    roundResults.Add("Win");
                    System.Console.WriteLine("Computer chose Paper");
                    System.Console.WriteLine("You win!");
                    System.Console.WriteLine();
                }
                else if (computer == 3)
                {
                    ties++;
                    roundResults.Add("Tie");
                    System.Console.WriteLine("Computer chose Scissors");
                    System.Console.WriteLine("It's a tie.");
                    System.Console.WriteLine();
                }
            }
            else
            {
                System.Console.WriteLine("Please enter ONLY 'r', 'p', or 's' ");
                roundnumber--;
            }

            roundnumber++;
        }

        public void PrintSummary()
        {
            foreach (var i in roundResults)
            {
                System.Console.Write(i + " | ");
            }

            System.Console.WriteLine();
            System.Console.WriteLine("Total Wins: " + wins);
            System.Console.WriteLine("Total Losses: " + losses);
            System.Console.WriteLine("Total Ties: " + ties);

            if(wins > losses)
            {
                System.Console.WriteLine("You're the Winner!");
            }
            else if (wins == losses)
            {
                System.Console.WriteLine("It's a tie.");
            }
            else
            {
                System.Console.WriteLine("Suck it, Loser!");
            }
        }

        int RandNum(int min, int max)   // Generate a random number between two numbers  
        {                               // includes the first number, excludes the second
            var rand = new Random();  
            return rand.Next(min, max);  
        }

    }
}