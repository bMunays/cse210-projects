using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Console.WriteLine("----- Guess the Random Number -----");

        // generate the random number and store in randomNumber
        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(0, 100);

        int response = 0;
        int guesses = 0;
        string playAgain = "yes";

        while (playAgain != "no")
        {
            while (response != randomNumber)
            {
                guesses += 1;

                // get users's guess
                Console.Write("What is your guess? ");
                response = int.Parse(Console.ReadLine());

                // make decisions
                if (response != randomNumber)
                {
                    if (randomNumber > response)
                    {
                        Console.WriteLine("Guess higher! ");
                    }
                    else
                    {
                        Console.WriteLine("Guess lower! ");
                    }
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {guesses} guesses.");
                }
            }

            Console.Write("Would you like to play again (yes/no)? ");
            playAgain = Console.ReadLine();

            if (playAgain == "no")
            {
                Console.WriteLine("Thank you for playing. Goodbye!");
            }
        }
    }
}