using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        //Prompt the user for a magic number and then convert that number into an integer. 
        // Console.WriteLine("What is your magic number?");
        // string magicNumberPrompt = Console.ReadLine();
        // int magicNumber = int.Parse(magicNumberPrompt);


        
        Console.WriteLine("This is a guessing game! You are required to guess the magic number, and the game will repeat until you do :)");
        Console.WriteLine("You will be required to guess a number between 1 and 100.");
        // this is code that is pulling a random number between 1 and 100
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        // Prompt the user for a number to guess and then convert that number into an integer. 
        Console.WriteLine("What is your guess?");
        string guessPrompt = Console.ReadLine();
        int guess = int.Parse(guessPrompt);
        int guessNumber = 0;
        string at = "";
        //These are a set of condition statements to guide the user through the game until they guess the magic number.
        do
        {

            if (magicNumber >= guess)
            {
                Console.WriteLine("higher :)");
            }
            else if (magicNumber <= guess)
            {
                Console.WriteLine("Lower :)");
            }
            // This is an if statement that will ask the user to guess again, retrieve another guess, and then convert the guess into an integer.
            if (magicNumber != guess)
            {
                Console.Write("Please guess again :");
                guessPrompt = Console.ReadLine();
                guess = int.Parse(guessPrompt);
            }
            if (magicNumber == guess)
            {
                Console.WriteLine("Great Job! You guessed it!");
                if (guessNumber > 5)
                {
                    at = ":(";

                }
                else
                {
                    at = ":)";
                }

                Console.WriteLine($"You Guessed {guessNumber} times {at}");
            }
            guessNumber = guessNumber + 1;





        }
        while (magicNumber != guess);
    }
}