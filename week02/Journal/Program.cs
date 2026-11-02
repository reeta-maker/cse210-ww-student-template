using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        string choice = "";

        while (choice != "5")
        {
            Console.WriteLine("\nWelcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            choice = Console.ReadLine();

            if (choice == "1")
            {
                string[] prompts =
                {
                    "Who was the most interesting person I interacted with today?",
                    "What was the best part of my day?",
                    "How did I see the hand of the Lord in my life today?",
                    "What was the strongest emotion I felt today?",
                    "If I had one thing I could do over today, what would it be?"
                    };

                Random random = new Random();
                int index = random.Next(prompts.Length);

                Console.WriteLine(prompts[index]);
                Console.Write("> ");
                string answer = Console.ReadLine();

                string date = DateTime.Now.ToShortDateString();

                Entry entry = new Entry();
                entry._date = date;
                entry._promptText = prompts[index];
                entry._entryText = answer;

                journal.AddEntry(entry);

                Console.WriteLine("Your entry has been added!");
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("Enter the filename to save: ");
                string filename = Console.ReadLine();

                journal.SaveToFile(filename);

                Console.WriteLine("Your journal has been saved!");
            }
            else if (choice == "4")
            {
                Console.Write("Enter the filename to load: ");
                string filename = Console.ReadLine();

                journal.LoadFromFile(filename);

                Console.WriteLine("Your journal has been loaded!");
            }
            else if (choice == "5")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }

}