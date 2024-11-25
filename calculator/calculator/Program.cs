using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool stop = false;

            do
            {
                double result = 0;

                // Get inputs
                double firstNumber = GetNumber("Enter first number: ");
                string op = GetOperator("Enter an operator (+, -, *, /): ");
                double secondNumber = GetNumber("Enter second number: ");

                // Perform calculation
                switch (op)
                {
                    case "+":
                        result = firstNumber + secondNumber;
                        break;
                    case "-":
                        result = firstNumber - secondNumber;
                        break;
                    case "*":
                        result = firstNumber * secondNumber;
                        break;
                    case "/":
                        if (secondNumber == 0)
                        {
                            Console.WriteLine("Error: Division by zero is not allowed.");
                            continue;
                        }
                        result = firstNumber / secondNumber;
                        break;
                    default:
                        Console.WriteLine("Invalid operator.");
                        continue;
                }

                // Display result
                Console.WriteLine($"Result: {result}");

                // Ask user to calculate again
                stop = !AskYesOrNo("Do you want to calculate again? (y/n): ");

            } while (!stop);
        }

        /// <summary>
        /// Prompts the user for a number and validates the input.
        /// </summary>
        static double GetNumber(string message)
        {
            double number;
            while (true)
            {
                Console.Write(message);
                if (double.TryParse(Console.ReadLine(), out number))
                    return number;

                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        /// <summary>
        /// Prompts the user for a valid operator.
        /// </summary>
        static string GetOperator(string message)
        {
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine();
                if (input == "+" || input == "-" || input == "*" || input == "/")
                    return input;

                Console.WriteLine("Invalid operator. Please enter one of +, -, *, /.");
            }
        }

        /// <summary>
        /// Prompts the user for a yes/no response and validates the input.
        /// </summary>
        static bool AskYesOrNo(string message)
        {
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine()?.Trim().ToLower();

                if (input == "y") return true;
                if (input == "n") return false;

                Console.WriteLine("Invalid input. Please enter 'y' or 'n'.");
            }
        }
    }
}