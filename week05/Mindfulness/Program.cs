using System;

/*
 * 1. Added a session counter in Program.cs that tracks how many mindfulness 
 *    activities the user completes during the session and displays it on the menu.
 * 2. Updated ReflectionActivity and ListingActivity so that random prompts and 
 *    questions are not repeated until every item in the list has been used once.
 */

class Program
{
    static void Main(string[] args)
    {
        int activitiesCompleted = 0;
        string choice = "";

        BreathingActivity breathing = new BreathingActivity();
        ReflectionActivity reflection = new ReflectionActivity();
        ListingActivity listing = new ListingActivity();

        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine($"Activities completed this session: {activitiesCompleted}");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                breathing.Run();
                activitiesCompleted++;
            }
            else if (choice == "2")
            {
                reflection.Run();
                activitiesCompleted++;
            }
            else if (choice == "3")
            {
                listing.Run();
                activitiesCompleted++;
            }
            else if (choice == "4")
            {
                Console.WriteLine();
                Console.WriteLine($"Great job! You completed {activitiesCompleted} mindfulness activities today. Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid option. Please enter a number between 1 and 4.");
                System.Threading.Thread.Sleep(2000);
            }
        }
    }
}
