using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        int magicNumber = int.Parse(Console.ReadLine());

        Console.Write("What is your guess? ");
        int guess = int.Parse(Console.ReadLine());

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