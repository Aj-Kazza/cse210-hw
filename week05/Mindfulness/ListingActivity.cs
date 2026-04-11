using System;
using System.Dynamic;

public class ListingActivity : Activity
{
    private int _count = 0;
    private List<string> _prompts = [
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"];
    public ListingActivity()
    {
        SetName("Listening");
        SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("\r\nList as many responses to the following prompt:");

        GetRandomPrompt();

        Console.WriteLine();
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        List<string> items = [];


        int time = GetDuration();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(time);

        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            _count = _count + 1;
            currentTime = DateTime.Now;
            
        }
        Console.WriteLine($"You listed {_count} items");

        DisplayEndingMessage();

        Console.Write("");
        Console.ReadLine();
    }

    public void GetRandomPrompt()
    {
        int length = _prompts.Count();
        Random rand = new Random();
        int randomNumber = rand.Next(1, length);
        int randomIndex = randomNumber - 1;
        Console.WriteLine($" --- {_prompts[randomIndex]} ---");
    }

    public List<string> GetListFromUser()
    {
        return [];
    }
}