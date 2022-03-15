namespace GuessingGame
{
    public class ConsoleIO
    {
        public static int GetMaxNumber()
        {
            string message = "Enter your maximum number: ";

            int maxNumber = PromptForPositiveInt(message);
            return maxNumber;
        }
        public static int PromptForPositiveInt(string message)
        {
            while (true)
            {
                Console.Write(message);

                if (int.TryParse(Console.ReadLine(), out int input))
                {
                    if (input < 1)
                    {
                        Console.WriteLine("Number must be positive.");
                    }
                    else
                    {
                        return input;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input enter a number please.");
                }

            }
        }
        public static int GetGuess(int maxNumber, int[] guesses)
        {
            string message = "Please guess the number: ";

            int guess = PromptForIntInRange(message, maxNumber);

            guess = CheckForDupes(guesses, guess);

            return guess;

        }
        public static int PromptForIntInRange(string message, int upperLimit)
        {
            while (true)
            {
                Console.Write(message);

                if (int.TryParse(Console.ReadLine(), out int input))
                {
                    if (input < 1)
                    {
                        Console.WriteLine("Number must be positive.");
                    }
                    else if (input > upperLimit)
                    {
                        Console.WriteLine("Number not in range");
                    }
                    else
                    {
                        return input;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input enter a number please.");
                }

            }
        }
        public static void PromptToContinue()
        {
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
        public static int CheckForDupes(int[] guesses, int guess)
        {
            while (true)
            {

                if (!Array.Exists(guesses, element => element == guess))
                {
                    return guess;
                }
                else
                {
                    Console.WriteLine("You've chosen this number try again.");
                }

            }
        }
        public static void ResponseMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
