using System;
using System.Reflection.Metadata;

public class Listing : Activity
{
    private List<string> prompts = new List<string>();
    private int entries;

    public Listing(string name, string description, int duration) : base(duration)
    {
        _name = name;
        _description = description;
    }

    public void RunListing(int duration)
    {
        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompt:");
        string prompt = GetPrompt();
        Console.WriteLine($" --- {prompt} ---");
        Console.Write("You may begin in: ");
        CountDownTime(5);
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);
        while (DateTime.Now < futureTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            entries += 1;
        }
        Console.WriteLine($"You listed {GetCount()} items!");
    }
    public string GetPrompt()
    {
        prompts.Add("Who are people that you appreciate?");
        prompts.Add("What are personal strengths of yours?");
        prompts.Add("Who are people that you have helped this week?");
        prompts.Add("When have you felt the Holy Ghost this month?");
        prompts.Add("Who are some of your personal heroes?");
        Random random = new Random();
        int rand = random.Next(5);
        string prompt = prompts[rand];
        return prompt;
    }
    public int GetCount()
    {
        return entries;
    }
}