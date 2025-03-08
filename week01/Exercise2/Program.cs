using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        // Prompt the user to enter their grade percentage and store it in the grade variable
        Console.Write("Please enter your grade percentage: ");
        string grade = Console.ReadLine();
        // Convert the grade variable to an integer
        int gradeInt = int.Parse(grade);
        // this is a set of condition statements that are going to produce a letter grade depending upon the users grade percentage
        if (gradeInt >= 90)
        {
            grade = "A";
        }
        else if (gradeInt >= 80)
        {
            grade = "B";
        }
        else if (gradeInt >= 70)
        {
            grade = "C";
        }
        else if (gradeInt >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }
        // this code will display the users letter grade on the scream based upon their grade percentage. 
        Console.WriteLine($"You Got a(n) {grade}");
        // this is a program that is going to consider if the user passed or failed the class
        if (gradeInt >= 70)
        {
            Console.WriteLine("Congrats!!! You passed the class!");
        }
        else if (gradeInt < 70)
        {
            Console.WriteLine("You failed :( Best of luck next time!");
        }
    }
}