using System;

class Program
{
    static void Main(string[] args)
    {
        int guesses = 0;
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        bool user = false;
        while (user == false)
        {
            Console.Write("What is your guess? ");
            String guessInput = Console.ReadLine();
            int guess = int.Parse(guessInput);
            if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
                guesses++;
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
                guesses++;
            }
            else
            {
                guesses++;
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"It took you {guesses} guesses.");
                user = true;
            }
        }
    }
}