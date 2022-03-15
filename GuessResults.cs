namespace GuessingGame
{
    public class GuessResults
    {
        public int[]? Guesses { get; set; }

        public int CountGuess(int count)
        {
            count = count + 1;

            return count;
        }
        public int[] StoreGuess(int guess)
        {
            for (int i = 0; i < Guesses.Length; i++)
            {
                if (Guesses[i] == 0)
                {
                    Guesses[i] = guess;
                }
            }
            return Guesses;

        }
    }
}
