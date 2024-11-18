
using System;
using System.Net.Http.Headers;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            bool exitGame = false;

            int drawScore = 0;
            int winScore = 0;
            int loseScore = 0;
            
            while (!exitGame)
            {
                int rand = rnd.Next(1, 4);
                string computerChoice = "";

                switch (rand)
                {
                    case 1:
                        computerChoice = "rock";
                        break;
                    case 2:
                        computerChoice = "paper";
                        break;
                    case 3:
                        computerChoice = "scissors";
                        break;
                    default:
                        throw new Exception("Unexpected random number");
                }
                
                Console.Write("Enter ROCK, PAPER or SCISSORS: ");
                string choice = Console.ReadLine();
                choice = choice.ToLower();

                if (choice == computerChoice)
                {
                    Console.WriteLine("Player: " + choice);
                    Console.WriteLine("Computer: " + computerChoice);
                    Console.WriteLine("Draw!");
                    drawScore++;
                } else if (choice == "rock" && computerChoice == "paper")
                {
                    Console.WriteLine("Player: " + choice);
                    Console.WriteLine("Computer: " + computerChoice);
                    Console.WriteLine("You lose!");
                    loseScore++;
                } else if (choice == "paper" && computerChoice == "scissors")
                {
                    Console.WriteLine("Player: " + choice);
                    Console.WriteLine("Computer: " + computerChoice);
                    Console.WriteLine("You lose!");
                    loseScore++;
                } else if (choice == "scissors" && computerChoice == "rock")
                {
                    Console.WriteLine("Player: " + choice);
                    Console.WriteLine("Computer: " + computerChoice);
                    Console.WriteLine("You lose");
                    loseScore++;
                } else if (choice == "paper" && computerChoice == "rock")
                {
                    Console.WriteLine("Player: " + choice);
                    Console.WriteLine("Computer: " + computerChoice);
                    Console.WriteLine("You win!");
                    winScore++;
                } else if (choice == "rock" && computerChoice == "scissors")
                {
                    Console.WriteLine("Player: " + choice);
                    Console.WriteLine("Computer: " + computerChoice);
                    Console.WriteLine("You win!");
                    winScore++;
                } else if (choice == "scissors" && computerChoice == "paper")
                {
                    Console.WriteLine("Player: " + choice);
                    Console.WriteLine("Computer: " + computerChoice);
                    Console.WriteLine("You win!");
                    winScore++;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again.");
                    continue;
                }

                bool stop = false;
                do
                {
                    Console.WriteLine("Score: win: " + winScore + ";  draw: " + drawScore + "; lose: " + loseScore);
                    Console.WriteLine("Would you like to play again? (Y/N): ");
                    string playAgain = Console.ReadLine();
                    
                    if (playAgain.Length > 0 && char.ToLower(playAgain[0]) == 'n')
                    {
                        Console.WriteLine("Thank you for playing!");
                        stop = true;
                        exitGame = true;
                    }
                    else if (playAgain.Length > 0 && char.ToLower(playAgain[0]) == 'y')
                    {
                        stop = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please try again.");
                        stop = false;
                        continue;
                    }
                } while (!stop);

            }
            
        }
    }
} 