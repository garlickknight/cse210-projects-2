using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");
    }
}
public class Fractions
{
    private int _Top = 0;
    private int _Bottom = 0;

    public Fractions()
    {
        _Top = 1;
        _Bottom = 1;
        string fraction = $"{_Top}/{_Bottom}";
    }
    public Fractions(int _Top)
    {
        _Bottom = 1;
        string fraction = $"{_Top}/{_Bottom}";
    }
    public Fractions(int _Top, int _Bottom)
    {
        string fraction = $"{_Top}/{_Bottom}";
    }

}