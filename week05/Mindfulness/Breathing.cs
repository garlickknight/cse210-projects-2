public class Breathing : Activity
{
    private void breathingActivity()
    {

        futureTime = DateTime.Now.AddSeconds(_runtime);
        while (DateTime.Now < futureTime)
        {
            Console.WriteLine("Breath In.... ");
            ShowCountdown(4, 1);
            Console.WriteLine("Breath Out...... ");
            ShowCountdown(6, 1);
        }
    }
    public void run()
    {
        breathingActivity();
    }
    
    
}