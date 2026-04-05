public class Assignments
{
    private string studentName;
    private string topic;

    public void getStudentName(string _studentName)
    {
        studentName = _studentName;

    }
    public void gettopic(string _topic)
    {
        topic = _topic;
    }
    public string GetSummary()
    {
        string summary = $"{studentName} : {topic}";
        return summary;
    }
};