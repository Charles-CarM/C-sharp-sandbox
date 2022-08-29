
namespace System
{
    class Program
    {
        static void Main(string[] args)

        //Guessing game

        {
            //string secretWord = "hamster";
            //string guess = "";
            //int guessCount = 0;

            //while (guess != secretWord)
            //{
            //    Console.Write("guess a word: ");
            //    guess = Console.ReadLine();

            //    //Console.WriteLine("guess again");
            //    guessCount++;
            //}
            //Console.Write("You win, number of guesses: " + guessCount);

            string passWord = "orangutan";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;

            do
            {
                if (guessCount < guessLimit)
                {
                    Console.WriteLine("enter a guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuesses = true;
                }

            } while (guess != passWord && !outOfGuesses);

            if (outOfGuesses)
            {
                Console.WriteLine("you lose");
            }
            else
            {
                Console.WriteLine("you win!");

            }

            Console.ReadLine();
        }
     
    }
}


