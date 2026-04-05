using System.Dynamic;
using System.Reflection.PortableExecutable;

public class MathAssignment : Assignments
{
    private string textBookSection;
    private string problems;
    private string assignment;

    

    public void SetAttrubutes(Assignments _assignment, string _textBookSection, string _problems)
    {
        Console.WriteLine("What is Your name?");
        string name = Console.ReadLine();
        Console.WriteLine("what Is Your topic?");
        string topic = Console.ReadLine();
        _assignment.getStudentName(name);
        _assignment.gettopic(topic);
        assignment = _assignment.GetSummary();
        textBookSection = _textBookSection;
        problems = _problems;
    }
    public string GetHomeworkList( )
    {
        string mathAssignment = $"{assignment} / {textBookSection} {problems}";
        return mathAssignment; 
    }
    
}