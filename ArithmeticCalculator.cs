public class ArithmeticCalculator : Arithmetics
{
    public double Add(double a, double b)
    {
        return a + b;
    }
    public double Divide(double a, double b)
    {
        if (b != 0)
        {
            return a / b;
        }
        return double.NaN;
    }
    public double Multiply(double a, double b)
    {
        return a * b;
    }
    public double Substract(double a, double b)
    {
        return a - b;
    }

    public double Remainder(double a, double b)
    {
        return a % b;
    }
}