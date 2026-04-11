using System;

public class Activity
{
    private string _name = "";
    private string _description = "";
    private int _duration = 0;

    public Activity()
    {
        
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to {_name} Activity");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        string duration = Console.ReadLine();
        _duration = int.Parse(duration);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} of {_name} Activity");
        
    }
    public void ShowSpinner(int seconds)
    {
        
        Console.Write("|");

        Thread.Sleep(500);

        Console.Write("\b \b");

        Thread.Sleep(500);

        Console.Write("\b \b");
        Console.Write("/");

        Thread.Sleep(500);

        Console.Write("\b \b");
        Console.Write("-");

        Thread.Sleep(500);

        Console.Write("\b \b");
        Console.Write("\\");

        Thread.Sleep(500);

        Console.Write("\b \b");
        Console.Write("|");

        Thread.Sleep(500);

        Console.Write("\b \b");
        Console.Write("/");

        Thread.Sleep(500);

        Console.Write("\b \b");
        Console.Write("-");

        Thread.Sleep(500);

        Console.Write("\b \b");
        Console.Write("\\");
    }

    public void ShowCountDown(int seconds)
    {
        Console.Write("3");

        Thread.Sleep(500);

        Console.Write("\b \b");
        Console.Write("2"); 

        Thread.Sleep(500);

        Console.Write("\b \b"); 
        Console.Write("1");
    }
}