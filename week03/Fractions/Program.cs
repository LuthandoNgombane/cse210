
using System;

class Program
{
    static void Main(string[] args)
    {
        //LN - Test Constructor 1: No parameters (1/1)
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        //LN - Test Constructor 2: One parameter (5/1)
        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        //LN - Test Constructor 3: Two parameters (3/4)
        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        //LN - Test Constructor 3: Two parameters (1/3)
        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());

        //LN - Test getters and setters
        Fraction f5 = new Fraction();
        f5.SetNumerator(7);
        f5.SetDenominator(2);
        Console.WriteLine($"After setters: {f5.GetFractionString()}");
        Console.WriteLine($"Numerator: {f5.GetNumerator()}, Denominator: {f5.GetDenominator()}");
    }
}