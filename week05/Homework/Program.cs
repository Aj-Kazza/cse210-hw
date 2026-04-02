using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        Assignment a1 = new Assignment("John Doe", "Stealth");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Jane Doe", "Trajectories", "6.7", "17-39");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Anon Yemouse", "Art of Ninjutsu", "How to Stealth like Ninjas");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());

    }
}