using System;

namespace numberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            char choice = 'y';
            
            do
            {
                int rand = random.Next(1, 100);
                int numberOfGuesses = 0;
                
                Console.WriteLine("Guess a number between 1 and 100");

                while (true)
                {
                    int guess = Convert.ToInt32(Console.ReadLine());
                    numberOfGuesses++;

                    if (guess < rand)
                    {
                        Console.WriteLine("Your number is too low");
                    } else if (guess > rand)
                    {
                        Console.WriteLine("Your number is to high");
                    } else if (guess == rand)
                    {
                        Console.WriteLine("You win!");
                        Console.WriteLine("Guesses: " + numberOfGuesses);
                        break;
                    }
                }

                do
                {
                    Console.WriteLine("Would you like to play again?(Y/N): ");
                    choice = Console.ReadLine()[0];
                    if (choice != 'Y' && choice != 'y' && choice != 'n' && choice != 'N')
                    {
                        Console.WriteLine("Invalid choice");
                    }
                } while (choice != 'Y' && choice != 'y' && choice != 'n' && choice != 'N');

                
            } while (choice == 'y' || choice == 'Y');

        }
    }
}