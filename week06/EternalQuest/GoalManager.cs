using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }


    public void Start()
    {
        int choice = 0;

        while (choice != 6)
        {
            Console.WriteLine();
            DisplayPlayerInfo();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");

            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if (choice == 1)
            {
                CreateGoal();
            }
            else if (choice == 2)
            {
                ListGoalDetails();
            }
            else if (choice == 3)
            {
                SaveGoals();
            }
            else if (choice == 4)
            {
                LoadGoals();
            }
            else if (choice == 5)
            {
                RecordEvent();
            }
            else if (choice == 6)
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
    }



    public void DisplayPlayerInfo()
    {
        int level = GetLevel();

        Console.WriteLine($"You have {_score} points.");
        Console.WriteLine($"Level: {level} - {GetLevelTitle()}");
    }

    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++) { Console.WriteLine($"{i + 1}. {_goals[i].GetShortName()}"); }
    }


    public void ListGoalDetails()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            string status;

            if (_goals[i].IsComplete())
            {
                status = "[X]";
            }
            else
            {
                status = "[ ]";
            }

            Console.WriteLine(
                $"{i + 1}. {status} {_goals[i].GetDetailsString()}");
        }
    }


    public void CreateGoal()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string choice = Console.ReadLine();
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());
        if (choice == "1")
        {
            SimpleGoal goal = new SimpleGoal(name, description, points); _goals.Add(goal);
        }
        else if (choice == "2")
        {
            EternalGoal goal = new EternalGoal(name, description, points); _goals.Add(goal);
        }
        else if (choice == "3")
        {
            Console.Write("How many times does this goal need to be completed? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for completing the goal? ");
            int bonus = int.Parse(Console.ReadLine());
            ChecklistGoal goal = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(goal);
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }


    public void RecordEvent()
    {
        ListGoalNames();

        Console.Write("Which goal did you accomplish? ");
        int choice = int.Parse(Console.ReadLine());

        if (choice < 1 || choice > _goals.Count)
        {
            Console.WriteLine("Invalid goal choice.");
            return;
        }

        Goal goal = _goals[choice - 1];

        if (goal is SimpleGoal && goal.IsComplete())
        {
            Console.WriteLine("That goal is already complete.");
            return;
        }

        // Remember the player's level before earning points.
        int oldLevel = GetLevel();

        bool wasComplete = goal.IsComplete();

        goal.RecordEvent();

        _score += goal.GetPoints();

        Console.WriteLine($"You earned {goal.GetPoints()} points!");

        // Give the checklist bonus when it is completed.
        if (!wasComplete && goal.IsComplete() && goal is ChecklistGoal checklistGoal)
        {
            _score += checklistGoal.GetBonus();

            Console.WriteLine(
                "Congratulations! You completed the checklist goal!");

            Console.WriteLine(
                $"You earned a bonus of {checklistGoal.GetBonus()} points!");
        }

        Console.WriteLine($"Your score is now {_score}.");

        // Check whether the player reached a new level.
        int newLevel = GetLevel();

        if (newLevel > oldLevel)
        {
            Console.WriteLine();
            Console.WriteLine("********************************");
            Console.WriteLine($"LEVEL UP! You are now level {newLevel}!");
            Console.WriteLine($"Rank: {GetLevelTitle()}");
            Console.WriteLine("********************************");
        }
    }




    public void SaveGoals()
    {
        Console.Write("What is the filename? ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved successfully.");
    }


    public void LoadGoals()
    {
        Console.Write("What is the filename? ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);

        _goals.Clear();
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');

            string goalType = parts[0];
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);

            if (goalType == "SimpleGoal")
            {
                SimpleGoal goal = new SimpleGoal(
                    name,
                    description,
                    points);

                if (bool.Parse(parts[4]))
                {
                    goal.RecordEvent();
                }

                _goals.Add(goal);
            }
            else if (goalType == "EternalGoal")
            {
                EternalGoal goal = new EternalGoal(
                    name,
                    description,
                    points);

                _goals.Add(goal);
            }
            else if (goalType == "ChecklistGoal")
            {
                int target = int.Parse(parts[4]);
                int amountCompleted = int.Parse(parts[5]);
                int bonus = int.Parse(parts[6]);

                ChecklistGoal goal = new ChecklistGoal(
                    name,
                    description,
                    points,
                    target,
                    bonus);

                for (int j = 0; j < amountCompleted; j++)
                {
                    goal.RecordEvent();
                }

                _goals.Add(goal);
            }
        }

        Console.WriteLine("Goals loaded successfully.");
    }


    public int GetLevel()
    {
        return (_score / 500) + 1;
    }

    public string GetLevelTitle()
    {
        int level = GetLevel();
        if (level == 1)
        {
            return "Iron";
        }
        else if (level == 2)
        {
            return "Bronze";
        }
        else if (level == 3)
        {
            return "Silver";
        }
        else if (level == 4)
        {
            return "Gold";
        }
        else if (level == 5)
        {
            return "Platinum";
        }
        else
        {
            return "Eternal Champion";
        }
    }


}
