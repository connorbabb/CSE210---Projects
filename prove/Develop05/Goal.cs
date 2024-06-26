using System;

public abstract class Goal
{
    private string _title;
    private string _description;
    private int _points;
    protected bool _completed;

    public Goal(string title, string description, int points, bool completed)
    {
        _title = title;
        _description = description;
        _points = points;
        _completed = completed;
    }

    public abstract bool IsComplete();
    public abstract void RecordEvent(UserInterface UI);
    public string GetTitle()
    {
        return _title;
    }
    public string GetDescription()
    {
        return _description;
    }
    public virtual int GetProgress()
    {
        return 0;
    }
    public virtual int GetRequired()
    {
        return 0;
    }
    public virtual int GetBonus()
    {
        return 0;
    }
    public int GetPoints()
    {
        return _points;
    }
}