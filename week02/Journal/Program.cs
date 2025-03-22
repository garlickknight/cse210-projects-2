using System;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

// I went above and beyond by making a 6th option that will find all of the entries made on a specific date, 
// and this will allow the user to find an entry made on a specific day.

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        JournalEntry newJournal = new JournalEntry();
        newJournal._prompts.Add("What was the highlight of your day?");
        newJournal._prompts.Add("What was the lowlight of your day?");
        newJournal._prompts.Add("How did you see the hand of God today?");
        newJournal._prompts.Add("What was the best interaction that you had today?");
        newJournal._prompts.Add("How did you make a difference in the world today?");
        newJournal._prompts.Add("What was the strongest emotion that I felt today?");
        newJournal._prompts.Add("What was one thing I would Change about today?");
        Console.Write("What is your Journal file name? Ex: 'journal.txt': ");
        string fileName = Console.ReadLine();
        DateTime dateTime = DateTime.Now;
        string currentDateTime = dateTime.ToShortDateString();
        Journal journal = new Journal();
        int response = 0;
        string entry = "";
        do
        {
            Random random = new Random();
            int randomIndex = random.Next(newJournal._prompts.Count);
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Desplay");
            Console.WriteLine("3. Load Journal");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("6. Load entry by date");
            Console.Write("Please enter your response here:");
            string responseString = Console.ReadLine();
            response = int.Parse(responseString);
            if (response == 1)
            {
                Console.Write("Your prompt for today is: ");
                Console.WriteLine(newJournal._prompts[randomIndex]);
                Console.Write($"{dateTime} response:");
                string newEntry = Console.ReadLine();
                entry = currentDateTime + " - " + newJournal._prompts[randomIndex] + " " + newEntry;
            }
            else if (response == 2)
            {
                Console.WriteLine($"Here is your last journal prompt:");
                Console.WriteLine(entry);
            }
            else if (response == 3)
            {
                string[] Lines = System.IO.File.ReadAllLines(fileName);
                foreach (string line in Lines)
                {
                    string[] parts = line.Split(currentDateTime);
                    Console.WriteLine(line);
                    Console.WriteLine();
                }
                ;
            }
            else if (response == 4)
            {
                journal.journal.Add(entry);
                using (StreamWriter outputFile = new StreamWriter(fileName, true))
                {
                    outputFile.WriteLine(entry);
                }


            }
            else if (response == 5)
            {
                Console.Write("Thank you! Please come again :)");
            }
            else if (response == 6)
            {
                Console.Write("What is the Date of the Entry that You Would Like to Load?");
                string[] Lines = System.IO.File.ReadAllLines(fileName);
                string dateEntry = Console.ReadLine();
                foreach (string line in Lines)
                {
                    if (dateEntry == currentDateTime)
                    {
                        string[] parts = line.Split(currentDateTime);
                        Console.WriteLine(line);
                        Console.WriteLine("");
                    }
                    ;
                }


            }
            else
            {
                Console.WriteLine("Please enter a number that is shown on the desplay. Thank you:)");
            }
        } while (response != 5);
    }
}