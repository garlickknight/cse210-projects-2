using System;

class Program
{
    static void Main(string[] args)
    {
        /*The first two lines of code are introducting the project and desplaying a prompt to the users screen */
        Console.WriteLine("Hello World! This is the Exercise1 Project.");
        Console.Write("Please enter your first name: ");
        /*This line is defining a variable and storeing the user's first name as the string variable*/
        string first_name = Console.ReadLine();
        /*This line of code is desplaying a prompt for the user asking for their last name.*/
        Console.Write("Please enter your last name: ");
        /*This line is defining a variable and storeing the user's last name as the string variable*/
        string last_name = Console.ReadLine();
        /*This line of code is desplaying the user's first and last name to the screen in the order that is required to complete this project*/
        Console.WriteLine("Your name is " + last_name + ", " + first_name +" " + last_name + ".");
    }
}