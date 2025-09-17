using System;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");
        Fractions _newFraction = new Fractions();
        Console.WriteLine($"{_newFraction.GetFractions()}");
        Console.WriteLine($"{_newFraction.GetDecimalValue()}");

        Fractions _secondFraction = new Fractions(5);
        Console.WriteLine($"{_secondFraction.GetFractions()}");
        Console.WriteLine($"{_secondFraction.GetDecimalValue()}");

        Fractions _thirdFraction = new Fractions(3, 4);
        Console.WriteLine($"{_thirdFraction.GetFractions()}");
        Console.WriteLine($"{_thirdFraction.GetDecimalValue()}");
    }
}
public class Fractions
{
    private int _Top = 0;
    private int _Bottom = 0;

    public decimal _decimal = 0m;


    public Fractions()
    {
        _Top = 1;
        _Bottom = 1;
        // fraction = $"{_Top}/{_Bottom}";
        // _decimal = _Top / _Bottom;

    }
    public Fractions(int _top)
    {
        _Bottom = 1;
        _Top = _top;
        // fraction = $"{_Top}/{_Bottom}";
        // _decimal = _Top / _Bottom;
    }
    public Fractions(int _top, int _bottom)
    {
        _Top = _top;
        _Bottom = _bottom;
        // fraction = $"{_Top}/{_Bottom}";
        // _decimal = _Top / _Bottom;
    }

    public double GetDecimalValue()
    {
        return (double)_Top / (double)_Bottom;
    }
    public string GetFractions()
    {
        string fraction = $"{_Top}/{_Bottom}";
        return fraction;
    }
}