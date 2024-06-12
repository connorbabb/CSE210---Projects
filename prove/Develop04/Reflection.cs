using System;

public class Reflection : Activity
{
    private List<string> prompts1 = new List<string>();
    private List<string> questions = new List<string>();

    public Reflection(string name, string description, int duration) : base(duration)
    {
        _name = name;
        _description = description;
    }

    public void RunReflection(int duration)
    {
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:\n");
        string prompt = GetPrompt();
        Console.WriteLine($" ---  {prompt} ---\n");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        string user = " ";
        while (user != "")
        {
            user = Console.ReadLine();
        }
        Console.WriteLine("Now Ponder on each of the following questions as they are related to this experience");
        Console.Write("You may begin in: ");
        CountDownTime(3);

        Console.Clear();
        Console.WriteLine($" ---  {prompt} ---\n");
        for (int time = 0; time < duration; time+=12)
        {
            Console.Write($"{GetQuestion()} ");
            LoadingAnimation(12);
            Console.WriteLine();
        }
    }
    public string GetPrompt()
    {
        prompts1.Add("Think of a time when you stood up for someone else.");
        prompts1.Add("Think of a time when you did something really difficult.");
        prompts1.Add("Think of a time when you helped someone in need.");
        prompts1.Add("Think of a time when you did something truly selfless.");
        Random random = new Random();
        int rand = random.Next(4);
        string prompt = prompts1[rand];
        return prompt;
    }
    public string GetQuestion()
    {
        questions.Add("Why was this experience meaningful to you?");
        questions.Add("Have you ever done anything like this before?");
        questions.Add("How did you get started?");
        questions.Add("How did you feel when it was complete?");
        questions.Add("What made this time different than other times when you were not as successful?");
        questions.Add("What is your favorite thing about this experience?");
        questions.Add("What could you learn from this experience that applies to other situations?");
        questions.Add("What did you learn about yourself through this experience?");
        questions.Add("How can you keep this experience in mind in the future?");
        Random random = new Random();
        int rand = random.Next(9);
        string question = questions[rand];
        return question;
    } 
}