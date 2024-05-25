using System.Diagnostics;
using System.Globalization;

public class Fraction
{
    private int top;
    private int bottom;

    public Fraction()
    {
        top = 1;
        bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        top  = wholeNumber;
        bottom = 1;
    }

    public Fraction (int Top, int Bottom)
    {
        top = Top;
        bottom = Bottom;
    }

    public string GetFractionString()
    {
        string text = $" {top}/{bottom} ";
        return text;
    }

    public double GetDecimalValue()
    {
        return (double)top / (double)bottom;
    }
}