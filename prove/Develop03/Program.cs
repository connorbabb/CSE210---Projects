using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", "3", "5", "6");
        Scripture scripture = new Scripture(reference, "Trust in the LORD with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");
        string user = "";
        while (user != "quit")
        {
            Console.Clear();
            Console.Write(reference.ToString());
            Console.WriteLine(scripture.printWords());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            user = Console.ReadLine();
            if (scripture.IsCompletelyHidden(scripture.GetList()) == true)
            {
                user = "quit";
            }
            else if (user == "")
            {
                scripture.HideWords();
            }
        }
        Console.WriteLine("Exiting Program.");
    }
}