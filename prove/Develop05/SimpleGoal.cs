using System;
using System.Reflection;
using System.Runtime.CompilerServices;

public class SimpleGoal : Goal
{
    public SimpleGoal(string title, string description, int points, bool completed) : base(title, description, points, completed) {}

    public override bool IsComplete()
    {
        return _completed;
    }
    public override void RecordEvent(UserInterface UI)
    {
        if (_completed == false)
        {
            int pointsAchieved = this.GetPoints();
            UI.SetPoints(pointsAchieved);
            Console.WriteLine($"Congratulations! You have earned {pointsAchieved} points!");
            _completed = true;
        }
        else
        {
            Console.WriteLine("You have already completed this goal.");
        }
    }
}