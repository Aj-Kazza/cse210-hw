// Requirement Exceeding NOTE: Made a loop to make sure we don't get repeats of hidden words

using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        bool isRunning = true;
        

        Reference reference = new Reference("John", 14, 15);
        Scripture scripture = new Scripture(reference, "If ye love me, keep my commandments");

        Console.WriteLine(reference.GetDisplayText());
        Console.WriteLine(scripture.GetDisplayText());

        


        while (isRunning == true)
        {
            Console.Write("Press enter to continue or type 'quit' to finish: ");
            string reply = Console.ReadLine();

            if (reply == "quit")
            {
                 isRunning = false;
            }

            else
            {
                Random random = new Random();
                int num = random.Next(0,7);
                bool hidden = scripture.GetHiddenStatus(num);
                bool printed = false;
                while (printed != true)
                {
                    if (hidden == true)
                    {
                        num = random.Next(0,7);
                        hidden = scripture.GetHiddenStatus(num);
                    }
                    else
                    {
                        
                        scripture.HideRandomWords(num);
                        hidden = scripture.GetHiddenStatus(num);
                        printed = true;

                    }
                }
                scripture.HideRandomWords(num);
                Console.Clear();
                Console.WriteLine(reference.GetDisplayText());
                Console.WriteLine(scripture.GetDisplayText());

                if (scripture.IsCompletelyHidden() == true)
                {
                    isRunning = false;
                }
                
                
            }

            
            
        }


        
        
    }
}