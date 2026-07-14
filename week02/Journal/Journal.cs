public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry (Entry newEntry)
    {
        //Adds current date to _date
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        newEntry._date = dateText;

        //Adds current chosen random prompt to 
        PromptGenerator prompt1 = new PromptGenerator();
        string randPrompt = prompt1.GetRandomPrompt();
        newEntry._promptText = randPrompt;

        //Adds written text to _entryText
        Console.WriteLine($"{randPrompt}");
        Console.Write("> ");
        newEntry._entryText = Console.ReadLine();

        //Adds parsed int to _rating
        Console.WriteLine("How would you rate your day? (1-10)");
        Console.Write("> ");
        newEntry._rating = int.Parse(Console.ReadLine());

        //Appends new entry to _entries
        _entries.Add(newEntry);
    }


    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }


    public void SaveToFile(string file)
    {
        string filename = file;
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            Console.WriteLine($"Saving file to .... {filename}");

            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}||{entry._promptText}||{entry._entryText}||{entry._rating}");
            }
        }
    }


    public void LoadFromFile(string file)
    {
        string filename = file;
        Console.WriteLine($"Reading file from .... {filename}");
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            //Console.WriteLine(line);
            //entryDate||promptText||entryText
            string[] parts = line.Split("||");
            //parts[0] - entryDate
            //parts[1] - promptText
            //parts[2] - entryText
            //parts[3] - rating

            Entry newEntry = new Entry();
            newEntry._date = parts[0];
            newEntry._promptText = parts[1];
            newEntry._entryText = parts[2];
            newEntry._rating = int.Parse(parts[3]);

            _entries.Add(newEntry);
        }
    }

}