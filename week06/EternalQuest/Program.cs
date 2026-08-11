using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the EternalQuest Project.");

        // Creativity: I added a leveling and ranking system to the Eternal Quest. 
        // // Players gain a new level for every 500 points they earn. 
        // // Each level has a different rank: Iron, Bronze, Silver, Gold, 
        // // Platinum, and Eternal Champion. 
        // // The program also displays a special LEVEL UP message when 
        // // the player reaches a new level. 
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}