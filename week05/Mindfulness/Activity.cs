using System.Data.SqlTypes;
using System.Reflection.Metadata.Ecma335;

public class Activity
{
    private string name;
    private string description;
    public DateTime startTime;
    public DateTime futureTime;
    public int _runtime = 60; // Default runtime of 60 seconds

    // AI wrote this code.
    public void ShowCountdown(int seconds, int count)
    {
        if (count == 1)
        {
            for (int i = seconds; i > 0; i--)
            {
                string currentNumber = i.ToString();
                Console.Write(currentNumber);
                Thread.Sleep(1000);
                Console.Write(new string('\b', currentNumber.Length));
                Console.Write(new string(' ', currentNumber.Length));
                Console.Write(new string('\b', currentNumber.Length));
            }
        }
        else
        {
            List<string> animationStrings = new List<string> { "|", "/", "-", "\\" };
            DateTime endTime = DateTime.Now.AddSeconds(seconds);
            int i = 0;

            while (DateTime.Now < endTime)
            {
                Console.Write(animationStrings[i]);
                Thread.Sleep(500);
                Console.Write("\b \b");
                i = (i + 1) % animationStrings.Count;
            }
        }
    }
    public void startingMsgDesplay()
    {
        string startingMsg = $" This is the {name} activity \n \n {description} \n \n This activity will Last ({_runtime}) seconds \n Please prepare to begin :)";
        Console.WriteLine($"{startingMsg}");
        Console.WriteLine($"It will begin in: ");
        ShowCountdown(15, 1);
    }

    public void startingMsg(string _name, string _description)
    {
        name = _name;
        description = _description;
        Console.WriteLine("How long is the run time? (seconds)");
        int runtime = int.Parse(Console.ReadLine());
        _runtime = runtime;
        startingMsgDesplay();
    }

    public void endingMsgDesplay(string name)
    {
        Console.WriteLine("Great Job!");
        ShowCountdown(10, 2);
        Console.WriteLine($"You Just finished the {name} activity. This took you {_runtime} seconds.");
        Console.Write($"It will end in..... ");
        ShowCountdown(5, 1);
        Console.WriteLine("Thank You!");
    }
}
