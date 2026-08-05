using System;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

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

        Console.Clear();

        Console.WriteLine("Get Ready");
        ShowSpinner(3);
        Console.Write("\b \b");
        Console.WriteLine();

    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of {_name} Activity");
        
    }
    public void ShowSpinner(int seconds)
    {
        Console.Write("|");
        Thread.Sleep(125);
        int tick = seconds;
        while (tick != 0)
        
        {
            
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(125);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(125);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(125);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(125);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(125);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(125);
            Console.Write("\b \b");
            Console.Write("\\"); 
            Thread.Sleep(125);
            
            tick = tick -1;
        }

        
    }

    public void ShowCountDown(int seconds)
    {
        int tick = seconds;
        while (tick != 0)
        {
            Console.Write(tick);
            Thread.Sleep(1000);
            tick = tick - 1;
            Console.Write("\b \b");
        }
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }
    
    public int GetDuration()
    {
        return _duration;
    }
}