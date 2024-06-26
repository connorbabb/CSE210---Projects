using System;

public class EternalGoal : Goal
{
    public EternalGoal(string title, string description, int points, bool completed) : base(title, description, points, completed) {}

    public override bool IsComplete()
    {
        return false;
    }
    public override void RecordEvent(UserInterface UI)
    {
        int pointsAchieved = this.GetPoints();
        UI.SetPoints(pointsAchieved);
        Console.WriteLine($"Congratulations! You have earned {pointsAchieved} points!");
    }
}