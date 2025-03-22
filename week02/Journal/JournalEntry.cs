using System.IO;

public class JournalEntry
{
    public List<string> _prompts = new List<string>();
    public string _test;

    public void _displayPrompt()
    {
        foreach (string prompt in _prompts)
        {
            Console.WriteLine(prompt);
        }
    }
}
