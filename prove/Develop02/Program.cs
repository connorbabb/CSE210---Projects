using System;
using System.IO;
using System.Numerics;

class Program
{
    static public Journal workingJournal = new Journal();
    static void Main(string[] args)
    {
        List<Entry> entries = new List<Entry>();
        string choice = "0";
        Console.WriteLine("Welcome to the Journal Program!");
        while (choice != "6")
        {
            Console.WriteLine();
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Search");
            Console.WriteLine("6. Quit");
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();

            if (choice == "1") {
                Entry entry = new Entry();
                entry = entry.GetEntry();
                entries.Add(entry);
            }
            else if (choice == "2") {
                Console.WriteLine();
                workingJournal.DisplayAllEntries(entries);
            }
            else if (choice == "3") {
                workingJournal.LoadFile();
            }
            else if (choice == "4") {
                workingJournal.SaveFile(entries);
            }
            else if (choice == "5") {
                Console.WriteLine("What date or string would you like to search for? ");
                string search = Console.ReadLine();
                Console.WriteLine("What file do you want to search in? ");
                string filename = Console.ReadLine();
                workingJournal.SearchFile(search, filename);
            }
            else if (choice == "6") {
                Console.WriteLine("Exiting program.");
            }
            else {
                Console.WriteLine("Invalid input. Please try again.");
            }
        }
    }
}