using System.Dynamic;

public class Reference2
{
    private string _book;

    private int _chapter;

    private int _verse;

    public Reference2(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public string GetDesplayText()
    {
        string reference = $"{_book} {_chapter}:{_verse}";
        return reference;
    }

    
}