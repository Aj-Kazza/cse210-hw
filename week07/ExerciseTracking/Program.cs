using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        List<Activity> activities = new List<Activity>();

        activities.Add(new Running(new DateTime(2026, 8, 4), 30, 4.8));
        activities.Add(new Cycling(new DateTime(2026, 8, 5), 30, 20));
        activities.Add(new Swimming(new DateTime(2026, 8, 6), 30, 40));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}