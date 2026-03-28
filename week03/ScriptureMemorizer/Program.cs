using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        bool isCompletelyHidden = false;

        Reference reference = new Reference("John", 14, 15);
        Scripture scripture = new Scripture(reference, "If ye love me, keep my commandments");

        Console.WriteLine(reference.GetDisplayText());
        Console.WriteLine(scripture.GetDisplayText());

        while (isCompletelyHidden != true)
        {
            
            
        }


        Random random = new Random();
        int num = random.Next(0,6);
        Console.WriteLine(num);
        scripture.HideRandomWords(num);
        Console.WriteLine(scripture.GetDisplayText());
    }
}