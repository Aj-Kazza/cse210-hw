using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        SetName("Breathing");
        SetDescription("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing");
    }

    public void Run()
    {
        DisplayStartingMessage();
        int time = GetDuration();
        while (time > 0)
        {
            Console.WriteLine();
            Console.Write($"Breathe in... ");
            ShowCountDown(4);
            Console.WriteLine();
            Console.Write("Now breathe out... ");
            ShowCountDown(6);
            Console.WriteLine();
            time = time - 10;
        }
        
        DisplayEndingMessage();

        Console.Write("");
        Console.ReadLine();
        
    }
}