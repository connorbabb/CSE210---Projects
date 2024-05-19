using System;
using System.IO;

class Journal
{
    public void LoadFile()
    {
        Console.WriteLine("Please enter the filename ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
    public void SaveFile(List<Entry> entries)
    {
        Console.WriteLine("Please enter the filename ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename, true))
        {
            foreach (Entry entry in entries)
                outputFile.WriteLine(entry.DisplayEntry(entry));
        }
        entries.Clear();
    }
    public void DisplayAllEntries(List<Entry> entries) 
    {
        foreach (Entry entry in entries) {
            Console.WriteLine(entry.DisplayEntry(entry));
        }
    }
    public void SearchFile(string search, string filename) 
    {
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            
        }
    }
}