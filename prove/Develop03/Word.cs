using System.Text;

public class Word
{
    // Here are my attributes
    private string _text;
    private bool _isHidden;

    // Here are my constructors
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // Here are my methods
    public void Hide()
    {
        int textLength = _text.Length;
        _text = String.Concat(Enumerable.Repeat("_", textLength));

        _isHidden = true;
    }

    // I did not need to use the "Show" method
    // public void Show()
    // {
    //     _isHidden = false;
    // }
    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {
        return _text;
    }
}