using System;

class Program
{
    static void Main(string[] args)
    {
        string play = "yes";

        while (play != "no")
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 11);

           string correct = "no";
            int guess = -1;
            int guesses = 0;


            while (correct == "no")
            {
                Console.Write("What is the magic number? ");
                guess = int.Parse(Console.ReadLine());
                guesses += 1;

                if (number > guess)
                {
                    Console.WriteLine("Higher");
                }
                else if (number < guess)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"You guessed it! The magic number is {number}");
                    Console.WriteLine($"You've guessed {guesses} amount of time(s)");
                    correct = "yes";
                    
                    Console.Write("Do you want to play again?(yes/no) ");
                    string reply = Console.ReadLine();
                    if (reply == "no")
                    {
                        play = "no";
                    }

                }

                

            }

        }
    }
}