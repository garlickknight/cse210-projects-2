using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Xml.Schema;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project."); 
        // creating a number varable
        int number = -1;
        // creating a sum varable
        int sum = 0;
        // creating a list
        List<int> numberList = new List<int>();
        // This line of code is going to use a while loop to collect all of the numbers that the user wants to take in order to create a list of integers. 
        while (number != 0)
        {
            // code to prompt the user for a number to add to their list, convert the prompt into a number in order to be stored in the list.
            Console.Write("(input 0 if you are done) What number do you want to add to your list?");
            string prompt = Console.ReadLine();
            number = int.Parse(prompt);
            // code to add the number into the list if the number is not 0. 
            if (number != 0)
            {
                numberList.Add(number);
                // code to caculate the sum of the numers in the list. 
                sum = sum + number;
            }

        }
        // this code is calculating the sum using a float as the specified variable.
        float average = (float) sum / numberList.Count;
        // this is code writing the sum average and largest number for the user to see. The average and largest numbers are calculated inside the code. 
        Console.WriteLine($"The sum of the list is {sum}.");
        Console.WriteLine($"The average of the list is {average}.");
        Console.WriteLine($"The largest number is {numberList.Max()}");
    }
}