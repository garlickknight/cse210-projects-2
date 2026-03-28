using System.Transactions;

public class Comment
{
    public string _name { get; set; }

    public string _comment { get; set; }
    public Comment(string name, string text)
    {
        _name = name;
        _comment = text;
    }
}