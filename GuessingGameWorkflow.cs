namespace GuessingGame
{
    public class GuessingGameWorkflow
    {
        
        public bool CheckGuess(int guess, int count, int randomNumber)
        {
            bool playing = true;

            if (guess == randomNumber)
            {
                string message = $"You got it and it only took {count} tries!";
                ConsoleIO.ResponseMessage(message);
                playing = false;
            }
            else if (guess < randomNumber)
            {
                string message = "Wrong, maybe try higher";
                ConsoleIO.ResponseMessage(message);
                playing = true;
            }
            else
            {
                string message = "Wrong, maybe try lower";
                ConsoleIO.ResponseMessage(message);
                playing = true;
            }
            return playing;
        }
        public void Run()
        {
            RandomNumber r = new RandomNumber();
            GuessResults g = new GuessResults();

            r.MaxNumber = ConsoleIO.GetMaxNumber();
            g.Guesses = new int[r.MaxNumber];
            int randomNumber = r.Randomize();
            bool playing = true;
            int count = 0;
            
            while (playing)
            {
                int guess = ConsoleIO.GetGuess(r.MaxNumber, g.Guesses);

                count = g.CountGuess(count);

                g.Guesses = g.StoreGuess(guess);

                playing = CheckGuess(guess, count, randomNumber);
            }
        }
    }
}
