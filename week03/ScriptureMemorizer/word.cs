
public class Word2
{

    private string _text;
    private bool _isHidden;

    public Word2(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDesplayText()
    {
        if (_isHidden)
        {
            return new string('_', _text.Length);
        } return _text; // AI helped me with this concept
    }
}
