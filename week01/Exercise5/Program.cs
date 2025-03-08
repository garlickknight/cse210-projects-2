using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        static string welcome()
        {
            string welcomeMessage = "Welcome to this assingment";
            return welcomeMessage;
        }
        static string name()
        {
            Console.Write("What is your name?");
            string namePrompt = Console.ReadLine();
            return namePrompt;
        }
        static int favoriteNumber()
        {
            Console.Write("What is your favorite number?");
            string numberPrompt = Console.ReadLine();
            int number = int.Parse(numberPrompt);
            return number;
        }

        static int SquareNumber(int favoriteNumber)
        {
            int total = favoriteNumber * favoriteNumber;
            return total;
        }
        static void Display(string welcome)
        {
            Console.WriteLine(welcome);
            Console.WriteLine($"{name()}, your number squared is {SquareNumber(favoriteNumber())}.");

        }
        Display(welcome());

    }
}