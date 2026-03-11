using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string grade = "";
        string signifier = "";

        if (percent >= 90)
        {
            grade = "A";
            if (percent < 93)
            {
                signifier = "-";
            }
        }
        else if (percent >= 80)
        {
            grade = "B";
            if (percent >= 87)
            {
                signifier = "+";
            }
            else if (percent < 83)
            {
                signifier = "-";
            }
        }
        else if (percent >= 70)
        {
            grade = "C";
            if (percent >= 77)
            {
                signifier = "+";
            }
            else if (percent < 73)
            {
                signifier = "-";
            }
        }
        else if (percent >= 60)
        {
            grade = "D";
            if (percent >= 67)
            {
                signifier = "+";
            }
            else if (percent < 63)
            {
                signifier = "-";
            }
        }
        else
        {
            grade = "F";
        }

        Console.WriteLine($"Your grade is: {grade}{signifier}");

        if (percent >= 70)
        {
            Console.WriteLine("You Passed!!");
        }
        else
        {
            Console.WriteLine("You Failed!!");
        }
    }
}