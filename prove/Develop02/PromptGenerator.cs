using System;

class PromptGenerator
{
    List<Prompt> promptsList = new List<Prompt>();
    Prompt prompt01 = new Prompt();
    Prompt prompt02 = new Prompt();
    Prompt prompt03 = new Prompt();
    Prompt prompt04 = new Prompt();
    Prompt prompt05 = new Prompt();
    Prompt prompt06 = new Prompt();
    Prompt prompt07 = new Prompt();
    Prompt prompt08 = new Prompt();
    public string GeneratePrompt() 
    {
        promptsList.Add(prompt01);
        promptsList.Add(prompt02);
        promptsList.Add(prompt03);
        promptsList.Add(prompt04);
        promptsList.Add(prompt05);
        promptsList.Add(prompt06);
        promptsList.Add(prompt07);
        promptsList.Add(prompt08);
        prompt01._prompt = "Who was the most interesting person I interacted with today? ";
        prompt02._prompt = "What was the best part of my day? ";
        prompt03._prompt = "How did I see the hand of the Lord in my life today? ";
        prompt04._prompt = "What was the strongest emotion I felt today? ";
        prompt05._prompt = "If I had one thing I could do over today, what would it be? ";
        prompt06._prompt = "What was something nice you did today for someone? ";
        prompt07._prompt = "What was the funniest thing that happened today? ";
        prompt08._prompt = "Where did you go today that was cool? ";
        Random random = new Random();
        int randomNumber = random.Next(0, 8);
        return promptsList[randomNumber]._prompt;
    }
}
class Prompt 
{
    public string _prompt;
}