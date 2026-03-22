public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public int _rating;

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine(_entryText);
        Console.WriteLine($"Entry Rating:   {_rating}/10");
        Console.WriteLine();
        
    }
}