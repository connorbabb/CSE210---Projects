using System;

class Entry
{
    string _dateText;
    string _prompt;
    string _userEntry;
    public Entry GetEntry() 
    {
        Entry entry = new Entry();
        DateTime currentDate = DateTime.Now;
        string dateText = currentDate.ToShortDateString();
        PromptGenerator promptGenerator = new PromptGenerator();
        string prompt = promptGenerator.GeneratePrompt();
        Console.WriteLine(prompt);
        string userEntry = Console.ReadLine();
        entry._dateText = dateText;
        entry._prompt = prompt;
        entry._userEntry = userEntry;
        return entry;
    }
    public string DisplayEntry(Entry entry) 
    {
        string dateText = entry._dateText;
        string prompt = entry._prompt;
        string userEntry = entry._userEntry;
        string Entry =  $"Date: {dateText} - Prompt: {prompt}\n{userEntry}\n";
        return Entry;
    }
}