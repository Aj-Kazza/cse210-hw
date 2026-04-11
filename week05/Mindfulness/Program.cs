using System;

class Program
{
    static void Main(string[] args)
    {

        int times = 0;
        bool selecting = true;

        while (selecting == true)
        {


            Console.WriteLine("Menu Options:");
            Console.WriteLine("     1.Start breathing activity");
            Console.WriteLine("     2.Start reflecting activity");
            Console.WriteLine("     3.Start listing activity");
            Console.WriteLine("     4.Quit");

            Console.Write("Select a choice from the menu: ");
            string select = Console.ReadLine();

            if (select == "1")
            {
                BreathingActivity activity = new BreathingActivity();
                activity.Run();
                times = times + 1;
                Console.Clear();
            }
            else if (select == "2")
            {
                ReflectionActivity activity = new ReflectionActivity();
                activity.Run();
                times = times + 1;
                Console.Clear();
            }
            else if (select == "3")
            {
                ListingActivity activity = new ListingActivity();
                activity.Run();
                times = times + 1;
                Console.Clear();
            }
            else if (select == "4")
            {
                selecting = false;
                Console.WriteLine($"You have done {times} mindfulness activities");
            }

         
        }

    }
}