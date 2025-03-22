public class Journal
{
    public List<String> journal = new List<string>();

    public void _Desplay()
    {
        foreach (string entry in journal)
        {
            Console.WriteLine(entry);
        }
    }
}