using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public class Resume
{
    public string _name;

    public List<Job> _Jobs = new List<Job>();
    public void _resumeDisplay()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (Job job in _Jobs)
        {
            job._showJob();
        }
        

    }

};
