using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3, 16);

        string text = "For God so loved the world that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";

        Scripture scripture = new Scripture(reference, text);

        string input = "";

        while (input != "quit" && !scripture.AllWordsHidden())
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine();

            Console.WriteLine("Press Enter to continue or type 'quit' to finish:");

            input = Console.ReadLine();

            if (input != "quit")
            {
                scripture.HideRandomWords(3);
            }
        }

        Console.WriteLine("Goodbye!");
    }
}