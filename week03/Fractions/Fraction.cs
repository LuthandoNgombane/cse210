using System;

public class Fraction
{
    //LN -  Private attributes for encapsulation
    private int _numerator;
    private int _denominator;

    //LN - Constructor 1: No parameters, defaults to 1/1
    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    //LN - Constructor 2: One parameter for numerator, denominator defaults to 1
    public Fraction(int numerator)
    {
        _numerator = numerator;
        _denominator = 1;
    }

    //LN - Constructor 3: Two parameters for numerator and denominator
    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }

    //LN - Getter for numerator
    public int GetNumerator()
    {
        return _numerator;
    }

    //LN - Setter for numerator
    public void SetNumerator(int numerator)
    {
        _numerator = numerator;
    }

    //LN - Getter for denominator
    public int GetDenominator()
    {
        return _denominator;
    }

    //LN - Setter for denominator
    public void SetDenominator(int denominator)
    {
        _denominator = denominator;
    }

    //LN - Method to return fraction as a string (e.g., "3/4")
    public string GetFractionString()
    {
        return $"{_numerator}/{_denominator}";
    }

    //LN - Method to return decimal value (e.g., 0.75)
    public double GetDecimalValue()
    {
        return (double)_numerator / _denominator;
    }
}