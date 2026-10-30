using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        Console.Write("What is your guess? ");
        int guess = -1;
        while (guess != magicNumber)
        {
            guess = int.Parse(Console.ReadLine());

            if (guess > magicNumber)
            {
                Console.WriteLine("Your guess is too high.");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Your guess is too low.");
            }
            else
            {
                Console.WriteLine("Congratulations! You guessed the magic number!");
            }

        }
    }
}