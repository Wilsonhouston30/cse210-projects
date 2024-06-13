using System.Dynamic;

public class Fraction
{
    private int top;
    private int bottom;

    public Fraction( )
    {
        Top = 1;
        Bottom = 1;
    }

    public Fraction (int top)
    {
        Top = top;
        Bottom = 1;
    }

    public Fraction (int top, int bottom)
    {
        Top = top;
        Bottom = bottom;
    }

    public int Top 
    {
        get {return top;}
        set {top = value;}

    }

    public int Bottom
    {
        get {return bottom;}
        set 
        {
            if (value != 0)
            {
                bottom = value;
            }
            else 
            {
                throw new ArgumentException ("The bottom value doesn't equal 0");
            }
        }
    }

    public string GetFractionString()
    {
        return  $"{top}/{bottom}";
    }

    public double GetDecimalForm()
    {
        return (double)top / bottom;
    }

}