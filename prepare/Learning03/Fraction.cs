using System.ComponentModel;

public class Fraction
{
    // Here are my private attributes
    private int _top;
    private int _bottom;

    // Here are my three constructors
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
    
    // Here are my Get and Set methods
    public void GetTop()
    {
        Console.WriteLine(_top);
    }
    public void SetTop(int top)
    {
        _top = top;
    }
    public void GetBottom()
    {
        Console.WriteLine(_bottom);
    }
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }
    public string GetFractionString()
    {
        return _top + "/" + _bottom;
    }
    public double GetDecimalValue()
    {
        double _top1 = _top;
        double _bottom1 = _bottom;
        double doub = (_top1 / _bottom1);

        return doub;
    }
}