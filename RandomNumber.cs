namespace GuessingGame
{
    public class RandomNumber
    {
        private Random _rng = new Random();

        public int MaxNumber { get; set; }

        public int Randomize()
        {
            int randomNumber = _rng.Next(1, MaxNumber);
            return randomNumber;
        }
    }
}
