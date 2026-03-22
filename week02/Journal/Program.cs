using System;

//added a "rate how your day went (1-10)"

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        bool writing = true;
        Journal journal = new Journal();

        while(writing != false)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string reply = Console.ReadLine();

            if (reply == "1")
            {
                Entry entry = new Entry();
                journal.AddEntry(entry);
                Console.WriteLine();
            }

            else if (reply == "2")
            {
                journal.DisplayAll();
            }

            else if (reply == "3")
            {
                Console.WriteLine("Where would you like to save to? ");
                Console.Write("> ");
                string fileName = Console.ReadLine();
                journal.SaveToFile(fileName);
                Console.WriteLine();
            }

            else if (reply == "4")
            {
                Console.WriteLine("Where would you like to load from? ");
                Console.Write("> ");
                string fileName = Console.ReadLine();
                journal.LoadFromFile(fileName);
                Console.WriteLine();
            }

            else if (reply == "5")
            {
                writing = false;
            }

            else
            {
                Console.WriteLine();
            }


        } 



        
    }
}