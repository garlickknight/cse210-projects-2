public class Listing : Activity
{
    List<string> prompts = new List<string>
    {
        "Who are people that have had a positive influence on your life?",
        "What are personal strengths of yours?",
        "Who are people that you appreciate?",
        "What are some of your challenges you have overcome?",
        "What do you feel grateful for?",
        "What moments in your life make you smile when you think of them?"
    };

    public void run()
    {
        string listingName = "Listing";
        startingMsg(($"{listingName}"), "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Console.Clear();
        Random random = new Random();
        Console.WriteLine(prompts[random.Next(prompts.Count)]);
        ShowCountdown(10, 1);
        DateTime endTime = DateTime.Now.AddSeconds(_runtime);
        int count = 0;
        while (DateTime.Now < endTime)
        {
            Console.ReadLine();
            count++;
        }
        Console.Clear();
        Console.WriteLine($"You listed {count} items.");
        endingMsgDesplay(listingName);
    }
}