using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
        List<Exercise> exercises = new List<Exercise>();
        Running running = new Running("14 April 2026", 30, 3.0f);
        Cycling cycling = new Cycling("14 April 2026", 45, 6.0f);
        Swimming swimming = new Swimming("14 April 2026", 20, 20);
        exercises.Add(running);
        exercises.Add(swimming);
        exercises.Add(cycling);
        foreach (Exercise exercise in exercises)
        {
            Console.WriteLine(exercise.getSummary());
        }
    }




}