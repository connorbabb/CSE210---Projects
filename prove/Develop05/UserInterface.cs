using System;
using System.Linq.Expressions;
using System.Threading.Channels;

public class UserInterface
{
    private int totalPoints;
    private List<Goal> goals = new List<Goal>();

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string goalType = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string title = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goals? ");
        int points = int.Parse(Console.ReadLine());
        
        if (goalType == "1")
        {
            SimpleGoal simpleGoal = new SimpleGoal(title, description, points, false);
            goals.Add(simpleGoal);
        }
        else if (goalType == "2")
        {
            EternalGoal eternalGoal = new EternalGoal(title, description, points, false);
            goals.Add(eternalGoal);
        }
        else if (goalType == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int bonusTimes = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonusPoints = int.Parse(Console.ReadLine());
            ChecklistGoal checklistGoal = new ChecklistGoal(title, description, points, bonusTimes, 0, bonusPoints, false);
            goals.Add(checklistGoal);
        }
    }
    public void DisplayGoals()
    {
        int i = 1;
        foreach (Goal goal in goals)
        {
            string status = "";
            if (goal.IsComplete() == false) status = " ";
            else if (goal.IsComplete() == true) status = "X";
            Console.Write($"{i}. [{status}] {goal.GetTitle()} ({goal.GetDescription()})");
            if (goal.GetType() == typeof(ChecklistGoal))
            {
                    Console.WriteLine($" -- Currently Completed: {goal.GetProgress()}/{goal.GetRequired()}");
            }
            else Console.WriteLine();
            i++;
        }
    }
    public void Save(List<Goal> goals)
    {
        Console.Write("Please enter the filename: ");
        string filename = Console.ReadLine();
        using (StreamWriter emptyFile = new StreamWriter(filename, false)) {}
        using (StreamWriter outputFile = new StreamWriter(filename, true))
        {
            outputFile.WriteLine(GetPoints());
            foreach (Goal goal in goals)
            {
                outputFile.Write($"{goal.GetType()},{goal.GetTitle()},{goal.GetDescription()},{goal.GetPoints()}");
                if (goal.GetType() == typeof(ChecklistGoal))
                {
                    outputFile.WriteLine($",{goal.GetBonus()},{goal.GetProgress()},{goal.GetRequired()}");
                }
                else if (goal.GetType() == typeof(SimpleGoal))
                {
                    outputFile.WriteLine($",{goal.IsComplete()}");
                }
                else
                {
                    outputFile.WriteLine();
                }
            }
        }
        goals.Clear();
    }
    public void Load()
    {
        Console.Write("Please enter the filename: ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        totalPoints = int.Parse(lines[0]);

        foreach (String line in lines)
        {
            string[] parts = line.Split(",");
            string pointsOrType = parts[0];

            if (pointsOrType == "SimpleGoal")
            {
                string title = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                bool status = bool.Parse(parts[4]);
                SimpleGoal simpleGoal = new SimpleGoal(title, description, points, status);
                goals.Add(simpleGoal);
            }
            else if (pointsOrType == "EternalGoal")
            {
                string title = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                EternalGoal eternalGoal = new EternalGoal(title, description, points, false);
                goals.Add(eternalGoal);
            }
            else if (pointsOrType == "ChecklistGoal")
            {
                string title = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                int bonus = int.Parse(parts[4]);
                int progress = int.Parse(parts[5]);
                int required = int.Parse(parts[6]);
                if (progress != required)
                {
                    ChecklistGoal checklistGoal = new ChecklistGoal(title, description, points, required, progress, bonus, false);
                    goals.Add(checklistGoal);
                }
                else
                {
                    ChecklistGoal checklistGoal = new ChecklistGoal(title, description, points, required, progress, bonus, true);
                    goals.Add(checklistGoal);
                }
            }
            else
            {
                totalPoints = int.Parse(pointsOrType);
            }
        }
    }
    public void FindEvent(UserInterface UI)
    {
        Console.WriteLine("The goals are:");
        int i = 1;
        foreach (Goal goal in goals)
        {
            Console.WriteLine($"  {i}. {goal.GetTitle()}");
            i++;
        }
        Console.Write("Which goal did you accomplish? ");
        int goalNumber = int.Parse(Console.ReadLine());
        Goal accomplishedGoal = goals[goalNumber - 1];
        accomplishedGoal.RecordEvent(UI);
    }
    public void SetPoints(int points)
    {
        totalPoints = totalPoints + points;
    }
    public int GetPoints()
    {
        return totalPoints;
    }
    public List<Goal> GetGoalList()
    {
        return goals;
    }
    public string GetRank()
    {
        if (totalPoints < 250)
        {
            return "Rookie";
        }
        else if (totalPoints >= 250)
        {
            return "Average";
        }
        else if (totalPoints >= 500)
        {
            return "Pro";
        }
        else if (totalPoints >= 750)
        {
            return "Hero";
        }
        else if (totalPoints >= 1000)
        {
            return "Legend";
        }
        else
        {
            return "Novice";
        }
    }
}