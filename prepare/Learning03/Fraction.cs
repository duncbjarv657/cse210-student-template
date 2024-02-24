using System;

public class Fraction
{
    private int numerator;
    private int denominator;

    public Fraction()
    {
        numerator = 1;
        denominator = 1;
    }
    public Fraction(int numerator)
    {
        this.numerator = numerator;
        this.denominator = 1;
    }

public Fraction(int numerator, int denominator)
{
    this.numerator = numerator;
    if (denominator != 0)
    {
       this.denominator = denominator;
    }
    else
    {
        Console.WriteLine("Denominator cannot be zero.");
        this.denominator = 1;
    }
}

public int Numerator
{
    get { return numerator; }
    set { numerator = value;}
}
public int Denominator
{
   get { return denominator; }
   set
   {
        if (value != 0)
        {
            denominator = value;
        }
        else
        {
           Console.WriteLine("Denominator cannot be zero.");
        }
    }
}

    public string GetFractionString()
    {
        return $"{numerator}/{denominator}";
    }

    public double GetDecimalValue()
    {
        return (double)numerator / denominator;
    }
 }

// class Program
// {

//     static void Main(string[] args)
//     {
//         Fraction fraction = new Fraction(3, 4);
//         Console.WriteLine("Fraction: " + fraction.FractionRepresentation());
//         Console.WriteLine("Decimal: " + fraction.DecimalRepresentation());
//         fraction.Numerator = 5;
//         fraction.Denominator = 8;
//         Console.WriteLine("Updated Fraction: " + fraction.FractionRepresentation());
//         Console.WriteLine("Updated Decimal: " + fraction.DecimalRepresentation());    
//     }
// }


