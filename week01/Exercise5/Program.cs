using System;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        Console.Write("What is your Name?");
        string name = Console.ReadLine();
        Console.Write("What is your favorite Number?");
        string numberPrompt = Console.ReadLine();
        int favoriteNumber = int.Parse(numberPrompt);
        Console.WriteLine($"{name}, your favorite number squared is {SquareNumber(favoriteNumber)}.");

        static int SquareNumber(int favoriteNumber)
        {
            int total = favoriteNumber * favoriteNumber;
            return total;
        }
    }
}