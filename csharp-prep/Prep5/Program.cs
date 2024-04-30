using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int x = PromptUserNumber();
        int squared = SquareNumber(x);
        DisplayResults(name, squared);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int favorite_number = int.Parse(Console.ReadLine());
        return favorite_number;
    }
    static int SquareNumber(int x)
    {
        int squared = x*x;
        return squared;
    }
    static void DisplayResults(string name, int squared)
    {
        Console.WriteLine($"{name}, the square of your number is {squared}");
    }
}