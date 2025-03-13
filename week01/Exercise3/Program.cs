using System;

class Program
{
    static void Main(string[] args)
    {

        //LN : Declare variables to store the magic number and the user's guess
        int magicNumber = 0;
        int userGuess = 0;
        int guessCount = 0;
        string playAgain = "yes";

        //LN : Create a random number generator
        Random random = new Random();

        //LN : Loop to keep playing the game until the user decides to stop
        while (playAgain == "yes")
        {
            //LN : Generate a random number between 1 and 100
            magicNumber = random.Next(1, 101);

            //LN : Reset the guess count
            guessCount = 0;

            //LN : Loop to keep asking the user for their guess until they guess the magic number
            while (userGuess != magicNumber)
            {
                //LN : Ask the user for their guess
                Console.Write("What is your guess? ");
                userGuess = Convert.ToInt32(Console.ReadLine());

                //LN : Increment the guess count
                guessCount++;

                //LN : Check if the user's guess is higher, lower, or correct
                if (userGuess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (userGuess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }

            //LN : Inform the user of the number of guesses they made
            Console.WriteLine("You made {0} guesses.", guessCount);

            //LN : Ask the user if they want to play again
            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine();
        }

        //LN : Thank the user for playing
        Console.WriteLine("Thank you for playing!");
    }
}