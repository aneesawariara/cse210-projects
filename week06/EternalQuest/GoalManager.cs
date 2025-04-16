using System;
using System.Collections.Generic;
using System.IO;


public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
        
        _score = 0;

    }

    public void Start()
    {
        
        while (true)
        {
            Console.WriteLine($"You have {_score} points");
            Console.WriteLine();
            Console.WriteLine("\nMenu Options: ");
            Console.WriteLine("\t1. Create New Goal");
            Console.WriteLine("\t2. List Goals");
            Console.WriteLine("\t3. Save Goals");
            Console.WriteLine("\t4. Load Goals");
            Console.WriteLine("\t5. Record Event");
            Console.WriteLine("\t6. Quit");
            
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();
            if (choice == "1")
            {
                CreateGoal();
            }
            else if (choice == "2")
            {
                ListGoalDetails();
            }
            else if (choice == "3")
            {
                Console.Write("Enter the file name to save to: ");
                string saveFile = Console.ReadLine();

                
                SaveGoals(saveFile);
            }
            else if (choice =="4")
            {
                Console.Write("Enter the file name to load from: ");
                string loadFile = Console.ReadLine();
                
                LoadGoals(loadFile);
            }
            else if (choice =="5")
            {
                RecordEvent();
            }
            else if (choice == "6")
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choce. Please try again.");
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("Your goals are: ");
        if (_goals.Count == 0)
        {
            Console.WriteLine("\tNo goals have been added.");
        }
        else
        {
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"\t{i + 1}. {_goals[i].GetShortName()}");
            }

        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are: ");

        if (_goals.Count == 0)
        {
            Console.WriteLine("\tNo goals have been added yet.");

        }
        else
        {
            foreach (Goal goal in _goals)
            {
                Console.WriteLine($"\t{goal.GetDetailsString()}");
            }
        }
    }

    public void CreateGoal()
    {
        
        
        Console.WriteLine("Goal Creation Menu: ");
        Console.WriteLine("\t1. Simple Goal");
        Console.WriteLine("\t2. Eternal Goal");
        Console.WriteLine("\t3. Checklist Goal");
        Console.WriteLine("\t4. Return to main menu");
            
        Console.Write("Which type of goal would you like to create? ");
        string choice = Console.ReadLine();

        if (choice == "1")
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            string points = Console.ReadLine();

            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (choice == "2")
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            string points = Console.ReadLine();

            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (choice == "3")
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            string points = Console.ReadLine();
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            int amountCompleted = 0;

            _goals.Add(new ChecklistGoal(name, description, points, bonus, target, amountCompleted));
        }
        
    }

    public void RecordEvent()
    {
        ListGoalNames();

        Console.Write("Which goal did you accomplish? ");
        int choice = int.Parse(Console.ReadLine());

        Goal selectedGoal = _goals[choice - 1];
        
        selectedGoal.RecordEvent();

        int pointsEarned = selectedGoal.GetPoints();

        _score += pointsEarned;
        Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");
        Console.WriteLine();
        Console.WriteLine($"You now have {_score} points");
    }

    public void SaveGoals(string fileName)
    {
        

        using (StreamWriter outputFile = new StreamWriter(fileName, append : true))
        {
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved successfully");
    }

    public void LoadGoals(string fileName)
{
    Console.WriteLine($"Loading goals from file: {fileName}");

    try
    {
        string[] lines = File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            Console.WriteLine($"Parts: {string.Join(" | ", parts)}"); // Debugging output

            string type = parts[0];
            string name = parts[1];
            string description = parts[2];
            string points = parts[3];

            if (type == "SimpleGoal")
            {
                bool isComplete = bool.Parse(parts[4]);
                SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                _goals.Add(simpleGoal);
                
            }
            else if (type == "EternalGoal")
            {
                EternalGoal eternalGoal = new EternalGoal(name, description, points);
                _goals.Add(eternalGoal);
                
            }
            else if (type == "ChecklistGoal")
            {
                int bonus = int.Parse(parts[4]);
                int target = int.Parse(parts[5]);
                int amountCompleted = int.Parse(parts[6]);
                ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, bonus, target, amountCompleted);
                _goals.Add(checklistGoal);
                
            }
        }

        Console.WriteLine("Goals successfully loaded!");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error loading file: {ex.Message}");
    }
}

}