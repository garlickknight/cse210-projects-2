using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");

        List<Goal> goals = new List<Goal>();
        int totalScore = 0;
        int input = 0;

        while (input != 6)
        {
            Console.WriteLine();
            Console.WriteLine($"You have {totalScore} points.");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create new Goal");
            Console.WriteLine("2. List Goal");
            Console.WriteLine("3. Save Goal");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");

            if (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Please enter a valid number.");
                input = 0;
                continue;
            }

            if (input == 1)
            {
                CreateGoal(goals);
            }
            else if (input == 2)
            {
                ListGoals(goals);
            }
            else if (input == 3)
            {
                Console.Write("What is your text file? ");
                string filePath = Console.ReadLine();
                SaveGoals(goals, totalScore, filePath);
            }
            else if (input == 4)
            {
                Console.Write("What is your text file? ");
                string filePath = Console.ReadLine();
                LoadGoals(goals, ref totalScore, filePath);
            }
            else if (input == 5)
            {
                RecordEvent(goals, ref totalScore);
            }
            else if (input == 6)
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("That menu choice is not valid.");
            }
        }
    }
    // ...existing code...

    static void CreateGoal(List<Goal> goals)
    {
        Console.WriteLine("What type of Goal?");
        Console.WriteLine("1. Simple");
        Console.WriteLine("2. Eternal");
        Console.WriteLine("3. Checklist");

        if (!int.TryParse(Console.ReadLine(), out int goaltype))
        {
            Console.WriteLine("Please enter a valid goal type.");
            return;
        }

        Console.Write("What is the name? ");
        string name = Console.ReadLine();
        Console.Write("What is the description? ");
        string description = Console.ReadLine();
        Console.Write("What is the points? ");

        if (!int.TryParse(Console.ReadLine(), out int points))
        {
            Console.WriteLine("Points must be a whole number.");
            return;
        }

        if (goaltype == 3)
        {
            Console.Write("What is the target count? ");
            if (!int.TryParse(Console.ReadLine(), out int targetcount))
            {
                Console.WriteLine("Target count must be a whole number.");
                return;
            }

            Console.Write("What is the bonus when you hit the target? ");
            if (!int.TryParse(Console.ReadLine(), out int bonus))
            {
                Console.WriteLine("Bonus must be a whole number.");
                return;
            }

            ChecklistGoal checklist = new ChecklistGoal(targetcount, bonus);
            checklist.goal(name, description, points);
            goals.Add(checklist);
        }
        else if (goaltype == 2)
        {
            EternalGoal eternal = new EternalGoal();
            eternal.goal(name, description, points);
            goals.Add(eternal);
        }
        else if (goaltype == 1)
        {
            SimpleGoal simple = new SimpleGoal();
            simple.goal(name, description, points);
            goals.Add(simple);
        }
        else
        {
            Console.WriteLine("That goal type is not valid.");
            return;
        }

        Console.WriteLine("Goal created.");
    }

    static void ListGoals(List<Goal> goals)
    {
        if (goals.Count == 0)
        {
            Console.WriteLine("There are no goals yet.");
            return;
        }

        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetStatus()}");
        }
    }

    static void RecordEvent(List<Goal> goals, ref int totalScore)
    {
        if (goals.Count == 0)
        {
            Console.WriteLine("There are no goals to record.");
            return;
        }

        ListGoals(goals);
        Console.Write("Which goal did you accomplish? ");

        if (!int.TryParse(Console.ReadLine(), out int goalIndex))
        {
            Console.WriteLine("Please enter a valid goal number.");
            return;
        }

        goalIndex -= 1;
        if (goalIndex < 0 || goalIndex >= goals.Count)
        {
            Console.WriteLine("That goal number is not valid.");
            return;
        }

        int earned = goals[goalIndex].RecordEvent();
        totalScore += earned;
        Console.WriteLine($"You earned {earned} points!");
    }

    static void SaveGoals(List<Goal> goals, int totalScore, string filePath)
    {
        if (string.IsNullOrWhiteSpace(filePath))
        {
            Console.WriteLine("Please enter a valid file name.");
            return;
        }

        List<string> lines = new List<string>
    {
        $"Score|{totalScore}"
    };

        foreach (Goal goal in goals)
        {
            if (goal is SimpleGoal simple)
            {
                lines.Add($"SimpleGoal|{simple.GetName()}|{simple.GetDescription()}|{simple.GetPoints()}|{simple.IsComplete()}");
            }
            else if (goal is ChecklistGoal checklist)
            {
                lines.Add($"ChecklistGoal|{checklist.GetName()}|{checklist.GetDescription()}|{checklist.GetPoints()}|{checklist.GetTargetCount()}|{checklist.GetBonus()}|{checklist.GetCurrentCount()}");
            }
            else if (goal is EternalGoal eternal)
            {
                lines.Add($"EternalGoal|{eternal.GetName()}|{eternal.GetDescription()}|{eternal.GetPoints()}");
            }
        }

        File.WriteAllLines(filePath, lines);
        Console.WriteLine("Goals saved.");
    }

    static void LoadGoals(List<Goal> goals, ref int totalScore, string filePath)
    {
        if (string.IsNullOrWhiteSpace(filePath) || !File.Exists(filePath))
        {
            Console.WriteLine("File not found.");
            return;
        }

        goals.Clear();
        string[] lines = File.ReadAllLines(filePath);

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');

            if (parts[0] == "Score")
            {
                int.TryParse(parts[1], out totalScore);
            }
            else if (parts[0] == "SimpleGoal")
            {
                SimpleGoal simple = new SimpleGoal();
                simple.goal(parts[1], parts[2], int.Parse(parts[3]));
                simple.SetComplete(bool.Parse(parts[4]));
                goals.Add(simple);
            }
            else if (parts[0] == "EternalGoal")
            {
                EternalGoal eternal = new EternalGoal();
                eternal.goal(parts[1], parts[2], int.Parse(parts[3]));
                goals.Add(eternal);
            }
            else if (parts[0] == "ChecklistGoal")
            {
                ChecklistGoal checklist = new ChecklistGoal(int.Parse(parts[4]), int.Parse(parts[5]));
                checklist.goal(parts[1], parts[2], int.Parse(parts[3]));
                checklist.SetCurrentCount(int.Parse(parts[6]));
                goals.Add(checklist);
            }
        }

        Console.WriteLine("Goals loaded.");
    }

}