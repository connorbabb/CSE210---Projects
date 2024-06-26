using System;

class Program
{
    static void Main(string[] args)
    {
        string user = "";
        UserInterface UI = new UserInterface();

        while (user != "6")
        {
            Console.WriteLine();
            Console.WriteLine($"{UI.GetRank()}: You have {UI.GetPoints()} points.\n");

            Console.WriteLine("Menu Options: ");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. Display Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            user = Console.ReadLine();
            Console.WriteLine();

            if (user == "1")
            {
                UI.CreateGoal();
            }
            else if (user == "2")
            {
                UI.DisplayGoals();
            }
            else if (user == "3")
            {
                UI.Save(UI.GetGoalList());
            }
            else if (user == "4")
            {
                UI.Load();
            }
            else if (user == "5")
            {
                UI.FindEvent(UI);
            }
            else if (user == "6")
            {
                Console.WriteLine("Exiting program.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
            }
        }
    }
}