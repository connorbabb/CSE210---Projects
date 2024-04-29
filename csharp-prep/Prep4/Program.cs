using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (number != 0)
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            number = int.Parse(input);
            if (number != 0)
            {
                numbers.Add(number);
            }
        }
        int sum = 0;
        float average = 0;
        int max = 0;
        int small = 0;
        foreach (int num in numbers)
        {
            sum = sum + num;
            if (num > max)
            {
                max = num;
            }
            if (num < max && num > 0)
            {
                small = num;
            }
        }
        Console.WriteLine($"The sum is: {sum}");
        float sum1 = sum;
        float count = numbers.Count;
        average = sum1 / count;
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The Largest Number is: {max}");
        Console.WriteLine($"The Smallest Positive Number is: {small}");
    }
}