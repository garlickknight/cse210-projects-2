public class Resume
{
    public string _name;

    public List<string> _Jobs;
    public void _resumeDesplay()
    {
        Console.WriteLine($"{_name}");
        Console.WriteLine($"{_Jobs}");
    }

};
