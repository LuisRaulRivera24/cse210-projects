using System;

class Program
{
    static void Main(string[] args)
    {
        // First constructor verification
        Fraction f = new Fraction();

        Console.WriteLine(f.GetFractionString());
        Console.WriteLine(f.GetDecimalValue());

        // // Verifying my Set and Get methods for the numerator and denominator.
        f.SetTop(5);
        // f.GetTop();

        // f.SetBottom(4);
        // f.GetBottom();

        Console.WriteLine(f.GetFractionString());
        Console.WriteLine(f.GetDecimalValue());

        // Second constructor verification
        Fraction f2 = new Fraction(6);

        f2.SetTop(3);
        // f2.GetTop();

        f2.SetBottom(4);
        // f2.GetBottom();

        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        // Third constructor verification
        Fraction f3 = new Fraction(6,7);

        f3.SetTop(1);
        // f3.GetTop();

        f3.SetBottom(3);
        // f3.GetBottom();

        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());
    }
}