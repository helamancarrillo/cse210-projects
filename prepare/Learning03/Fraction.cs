

public class Fraction 
{
    // member variables 

    private int _top;

    private int _bottom; 

    // constructors 

    public Fraction() // the non-argument one 1/1
    {
        _top = 1; 
        _bottom = 1;
        //Console.WriteLine($"{_top}/{_bottom}");
    }

    public Fraction(int wholenumber) // one parameter x/1
    {
        _top = wholenumber;
        _bottom = 1;
        //Console.WriteLine($"{_top}/{_bottom}");
    }

    public Fraction (int top, int bottom) // x/x
    {
        _top = top; 
        _bottom = bottom;
        //Console.WriteLine($"{_top}/{_bottom}");
    }

    // getters and setters 

    public int GetTop()
    {
        return _top; 
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // methods => functions 

    public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }  

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom; 

    }
 
}