using System;

class Program
{
    static void Main(string[] args)
    {
        // 1. Test the base Assignment class
        Assignment assignment1 = new Assignment("Kajol Pun", "Multiplication");
        Console.WriteLine(assignment1.GetSummary());

        // 2. Test the MathAssignment class
        MathAssignment math1 = new MathAssignment("Dirk Witters", "Fractions", "7.3", "8-19");
        Console.WriteLine(math1.GetSummary());
        Console.WriteLine(math1.GetHomeworkList());

        // 3. Test the WritingAssignment class
        WritingAssignment writing1 = new WritingAssignment("Reeta Pun", "European History", "The Causes of World War II");
        Console.WriteLine(writing1.GetSummary());
        Console.WriteLine(writing1.GetWritingInformation());
    }
}
