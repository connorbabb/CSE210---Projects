using System;
using System.Diagnostics.Contracts;

public class Activity
{
    protected int _duration;
    protected string _name;
    protected string _description;

    public Activity(int duration)
    {
        _duration = duration;
    }

    public void RunActvity(string _name, string _description)
    {
        DisplayStart(_name, _description);
        Console.Clear();
        Console.WriteLine("Get ready...");
        LoadingAnimation(5);
        if (_name == "Breathing")
        {
            Breathing breathing = new Breathing(_name, _description, 0);
            breathing.RunBreathing(_duration);
        }
        else if (_name == "Reflection")
        {
            Reflection reflection = new Reflection(_name, _description, 0);
            reflection.RunReflection(_duration);
        }
        else if (_name == "Listing")
        {
            Listing listing = new Listing(_name, _description, 0);
            listing.RunListing(_duration);
        }
        Console.WriteLine();
        DisplayEnd(_name);
    }
    public void DisplayStart(string _name, string _description)
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        int duration = int.Parse(Console.ReadLine());
        SetDuration(duration);
    }
    public void DisplayEnd(string _name)
    {
        Console.WriteLine("Well done!!");
        LoadingAnimation(3);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");
        LoadingAnimation(3);
        Console.Clear();
    }
    public void CountDownTime(int timer)
    {
        for (int time = timer; time > 0; time--)
        {
            Console.Write($"{time}\b");
            Thread.Sleep(1000);
        }
        Console.Write(" \b");
        Console.WriteLine();
    }
    public void LoadingAnimation(int time)
    {
        for (int loading = 0; loading < time; loading++)
        {
            int delay = 167;
            Console.Write("____\b\b\b\b");
            Thread.Sleep(delay);
            Console.Write("\\___\b\b\b\b");
            Thread.Sleep(delay);
            Console.Write("/\\__\b\b\b\b");
            Thread.Sleep(delay);
            Console.Write("_/\\_\b\b\b\b");
            Thread.Sleep(delay);
            Console.Write("__/\\\b\b\b\b");
            Thread.Sleep(delay);
            Console.Write("___/\b\b\b\b");
            Thread.Sleep(delay);
        }
        Console.Write("    \b\b\b\b");
    }
    public void SetDuration(int duration)
    {
        _duration = duration;
    }
}