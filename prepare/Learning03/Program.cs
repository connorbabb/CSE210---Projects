using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction01 = new Fraction();
        Fraction fraction02 = new Fraction(5);
        Fraction fraction03 = new Fraction(3, 4);
        Fraction fraction04 = new Fraction(1, 3);

        Console.WriteLine(fraction01.GetFractionString(fraction03));
        Console.WriteLine(fraction01.GetTop());
        Console.WriteLine(fraction02.GetFractionString(fraction02));
        Console.WriteLine(fraction02.GetTop());
        Console.WriteLine(fraction03.GetFractionString(fraction03));
        Console.WriteLine(fraction03.GetDecimalValue(fraction03));
        Console.WriteLine(fraction04.GetFractionString(fraction04));
        Console.WriteLine(fraction04.GetDecimalValue(fraction04));
    }
}