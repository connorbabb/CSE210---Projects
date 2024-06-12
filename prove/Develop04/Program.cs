using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        string user = "";
        int breatheTimes = 0;
        int reflectionTimes = 0;
        int listingTimes = 0;

        while (user != "4")
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflection Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            user = Console.ReadLine();
            if (user == "1")
            {
                breatheTimes++;
                string name = "Breathing";
                string description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
                Activity activity = new Activity(0);
                activity.RunActvity(name, description);
                Console.Clear();
                Console.WriteLine($" - You have completed the breathing activity {breatheTimes} time(s).");
            }
            else if (user == "2")
            {
                reflectionTimes++;
                string name = "Reflection";
                string description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
                Activity activity = new Activity(0);
                activity.RunActvity(name, description);
                Console.Clear();
                Console.WriteLine($" - You have completed the reflecting activity {reflectionTimes} time(s).");
            }
            else if (user == "3")
            {
                listingTimes++;
                string name = "Listing";
                string description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
                Activity activity = new Activity(0);
                activity.RunActvity(name, description);
                Console.Clear();
                Console.WriteLine($" - You have completed the listing activity {listingTimes} time(s).");
            }
            else if (user == "4")
            {
                Console.WriteLine("Exiting Program.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please retry.");
            }
        }
    }
}