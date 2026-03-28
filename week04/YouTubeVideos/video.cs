using System.Collections.Generic;

public class Video
{
    public string _title;
    public float _Length;
    public List<Comment> comments;
    public string Author;

    public Video()
    {
        comments = new List<Comment>();
    }

    public void AddComment(string name, string comment)
    {
        comments.Add(new Comment(name, comment));
    }

    public int commentNumber()
    {
        int I = 0;
        foreach (Comment comment in comments)
        {
            I = I + 1;
        }
        return I;
    }






    
}