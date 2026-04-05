using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        Console.WriteLine("What activity would you like to do?");
        Console.WriteLine("1. Breathing");
        Console.WriteLine("2. Reflection");
        Console.WriteLine("3. Listing");
        Console.WriteLine("Please input a number below:");
        int input = int.Parse(Console.ReadLine());
        Console.Clear();
        if (input == 1)
        {
            Breathing breathingActivity = new Breathing();
            string bName = "Breathing";
            breathingActivity.startingMsg(($"{bName}"), "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
            breathingActivity.run();
            breathingActivity.endingMsgDesplay(bName);
        }
        else if (input == 2)
        {
            Reflection reflection = new Reflection();
            reflection.run();
        }
        else if (input == 3)
        {
            Listing listing = new Listing();
            listing.run();
        }


    }
}