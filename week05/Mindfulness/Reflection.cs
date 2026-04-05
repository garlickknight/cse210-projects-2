public class Reflection : Activity
{
    private List<string> promps = new List<string>
    {
        "Why did you do something that was very helpful today?",
        "How did you feel when you completed a task?",
        "What did you learn about yourself today?",
        "How did you help someone in the past?",
        "What was the most challenging part of your day?",
        "How did you overcome that challenge?",
        "What are you grateful for today?",
        "How did you help someone today?"
    };
    private List<string> ponders = new List<string>
    {
        "Think about why that was helpful.",
        "Consider how your actions affected others.",
        "Reflect on what made you feel accomplished.",
        "Think about how this connects to your goals.",
        "What would you do differently next time?",
        "How did this challenge help you grow?",
        "Why is this something you're grateful for?",
        "How did that person benefit from your help?"

    };

    public void run()
    {
        string reflectionName = "Reflection";
        startingMsg(($"{reflectionName}"), "This activity will help you explore moments when you demonstrated courage and perseverance. By recognizing your inner strength during challenging times, you can apply that resilience to overcome obstacles in other areas of your life.");
        Console.Clear();
        Random random = new Random();
        Console.WriteLine(promps[random.Next(promps.Count)]);
        ShowCountdown(10, 1);

        DateTime endTime = DateTime.Now.AddSeconds(_runtime);
        int ii = 0;
        while (DateTime.Now < endTime)
        {
            Console.WriteLine(ponders[ii]);
            ShowCountdown(5, 2);
            ii++;
            if (ii >= ponders.Count)
            {
                ii = 0;
            }
        }

        Console.Clear();
        endingMsgDesplay(reflectionName);
    }





}