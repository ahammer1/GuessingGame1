using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome message and instructions
            Console.WriteLine("Welcome to the Number Guessing Game!");
            Console.WriteLine("Try to guess the secret number between 1 and 100.");

            // Prompt the user for difficulty level
            int maxAttempts;
            Console.WriteLine("Select difficulty level:");
            Console.WriteLine("1 - Easy (8 guesses)");
            Console.WriteLine("2 - Medium (6 guesses)");
            Console.WriteLine("3 - Hard (4 guesses)");
            Console.WriteLine("4 - Cheater (Unlimited guesses)");
            Console.Write("Enter the number of your choice (1/2/3/4): ");
            int difficultyChoice = int.Parse(Console.ReadLine());

            // Determine the maximum attempts based on difficulty level
            switch (difficultyChoice)
            {
                case 1:
                    maxAttempts = 8;
                    break;
                case 2:
                    maxAttempts = 6;
                    break;
                case 3:
                    maxAttempts = 4;
                    break;
                case 4:
                    maxAttempts = int.MaxValue; // A very large number to simulate unlimited guesses
                    break;
                default:
                    Console.WriteLine("Invalid choice. Easy difficulty level is selected by default.");
                    maxAttempts = 8;
                    break;
            }

            // Generate a random secret number between 1 and 100
            Random random = new Random();
            int secretNumber = random.Next(1, 101);

            // Phase 8: User's chosen difficulty level with a specific number of guesses or unlimited guesses
            int attempt = 1;
            while (attempt <= maxAttempts)
            {
                int guessesLeft = maxAttempts - attempt + 1;
                Console.Write("Your guess (Attempts left: " + guessesLeft + ")> ");
                int userGuess = int.Parse(Console.ReadLine());

                // Compare the user's guess with the secret number
                if (userGuess == secretNumber)
                {
                    Console.WriteLine("Congratulations! You guessed the secret number!");
                    break;
                }
                else if (attempt == maxAttempts)
                {
                    Console.WriteLine("Sorry, you have used all your chances. The secret number was " + secretNumber + ".");
                }
                else
                {
                    if (userGuess < secretNumber)
                    {
                        Console.WriteLine("Your guess is too low. Try again!");
                    }
                    else
                    {
                        Console.WriteLine("Your guess is too high. Try again!");
                    }
                }

                attempt++;
            }

            // Pause to see the result
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
