using System;

public class Breathing : Activity
{    public Breathing(string name, string description, int duration) : base(duration)
    {
        _name = name;
        _description = description;
    }

    public void RunBreathing(int duration)
    {
        Console.WriteLine();
        Console.Write("Breathe in...");
        CountDownTime(2);
        Console.Write("Now breathe out...");
        CountDownTime(3);
        for (int time = 5; time < duration; time += 10)
        {
            Console.WriteLine();
            Breathe();
        }
    }
    public void Breathe()
    {
        Console.Write("Breathe in...");
        CountDownTime(4);
        Console.Write("Now breathe out...");
        CountDownTime(6);
    }
}