using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning03 World!");
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(6);
        Fraction fraction3 = new Fraction(6,7);

        Console.WriteLine("Fraction 1: " + fraction1.GetFractionString());
        Console.WriteLine("Fraction 2: " + fraction2.GetFractionString());
        Console.WriteLine("Fraction 3: " + fraction3.GetFractionString());

        Console.WriteLine("Initial values: ");
        DisplayFractionDetails(fraction1);
        DisplayFractionDetails(fraction2);
        DisplayFractionDetails(fraction3);

        fraction1.Numerator = 3;
        fraction1.Denominator = 4;
        fraction2.Numerator = 5;
        fraction2.Denominator = 8;
        
        Console.WriteLine("\nUpdated values:");
        DisplayFractionDetails(fraction1);
        DisplayFractionDetails(fraction2);
        DisplayFractionDetails(fraction3);
    }

    static void DisplayFractionDetails(Fraction fraction)
    {
        Console.WriteLine("Fraction String: " + fraction.GetFractionString());
        Console.WriteLine("Decimal Value: " + fraction.GetDecimalValue());
    }
}