using System;

public class WritingAssigment : Assignment
{
    private string _title;

    public WritingAssigment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation() 
    {
        Console.WriteLine(GetSummary());
        return $"{_title} by {GetName()}";
    }
}