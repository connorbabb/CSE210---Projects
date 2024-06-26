using System;
using System.ComponentModel.DataAnnotations.Schema;

public class ChecklistGoal : Goal
{
    private int _required;
    private int _progress;
    private int _bonus;

    public ChecklistGoal(string title, string description, int points, int required, int progress, int bonus, bool completed) : base(title, description, points, completed) 
    {
        _required = required;
        _progress = progress;
        _bonus = bonus;
    }

    public override bool IsComplete()
    {
        return _completed;
    }
    public override void RecordEvent(UserInterface UI)
    {
        if (_completed == false)
        {
            int pointsAchieved;
            _progress = _progress + 1;
            if (_required == _progress)
            {
                pointsAchieved = this.GetBonus();
                UI.SetPoints(pointsAchieved);
                Console.WriteLine($"Congratulations! You have earned {pointsAchieved} points!");
                _completed = true;
            }
            else
            {
                pointsAchieved = this.GetPoints();
                UI.SetPoints(pointsAchieved);
            }
        }
        else
        {
            Console.WriteLine("You have already completed this goal.");
        }
    }
    public override int GetProgress()
    {
        return _progress;
    }
    public override int GetRequired()
    {
        return _required;
    }
    public override int GetBonus()
    {
        return _bonus;
    }
}