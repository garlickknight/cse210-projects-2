using System.Reflection;

public class WritingAssignment : Assignments
{
    private string title;
    private string assignmentname;

    public void titleConstructor(string name, string topic, string _title)
    {
        getStudentName(name);
        gettopic(topic);
        assignmentname = GetSummary();
        title = _title;
    }

    public string GetWritingAssignment()
    {
        string assignment = $"{assignmentname} / {title}";
        return assignment;
    }
}