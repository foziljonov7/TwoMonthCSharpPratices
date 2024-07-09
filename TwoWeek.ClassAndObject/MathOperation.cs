namespace TwoWeek.ClassAndObject;

//Sintaksis polymorhism
public class MathOperation
{
    public int Add(int n, int m)
    {
        return n + m;
    }

    public double Add(double n, double m)
    {
        return n + m;
    }

    public int Add(int n, int m, int k)
    {
        return n + m + k;
    }
}