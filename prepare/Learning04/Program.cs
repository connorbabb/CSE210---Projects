using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Connor Babb", "Divide");
        Console.WriteLine(assignment1.GetSummary());

        MathAssigment assignment2 = new MathAssigment("Connor Babb", "Divide", "2.4", "7-12");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());

        WritingAssigment assignment3 = new WritingAssigment("Connor Babb", "History", "The War");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInformation());
    }
}