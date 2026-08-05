using System;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = [
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."];
    private List<string> _questions = [
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?", "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"];
    public ReflectionActivity()
    {
        SetName("Reflection");
        SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        DisplayPrompt();
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.Write("");
        Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in:  ");
        ShowCountDown(5);

        Console.Clear();

        int time = GetDuration();
        while (time > 0)
        {
            Console.WriteLine();
            DisplayQuestions();
            ShowSpinner(10);
            Console.Write("\b \b");
            time = time -10;
        }


        DisplayEndingMessage();
        
        Console.Write("");
        Console.ReadLine();
        
    }
    public string GetRandomPrompt()
    {
        int length = _prompts.Count();
        Random rand = new Random();
        int randomNumber = rand.Next(1, length);
        int randomIndex = randomNumber - 1;
        return $"{_prompts[randomIndex]}";

    }

    public string GetRandomQuestion()
    {
        int length = _questions.Count();
        Random rand = new Random();
        int randomNumber = rand.Next(1, length);
        int randomIndex = randomNumber - 1;
        return $"{_questions[randomIndex]}";

    }

    public void DisplayPrompt()
    {
        string randomPrompt = GetRandomPrompt();
        Console.WriteLine($"  --- {randomPrompt} ---");
    }
    public void DisplayQuestions()
    {
        string randomQuestion = GetRandomQuestion();
        Console.Write($"> {randomQuestion} ");
    }
}