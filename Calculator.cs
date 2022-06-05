
public class Calculator : ArithmeticCalculator
{
    public static double DoOperation(double number1, double number2, string operation)
    {
        double result = 0;
        ArithmeticCalculator calculate = new ArithmeticCalculator();

        switch (operation)
        {
            case "a":
                result = calculate.Add(number1, number2);
                break;
            case "s":
                result = calculate.Substract(number1, number2);
                break;
            case "m":
                result = calculate.Multiply(number1, number2);
                break;
            case "d":
                result = calculate.Divide(number1, number2);
                break;
            case "r":
                result = calculate.Residue(number1, number2);
                break;
            default:
                break;
        }
        return result;
    }
}
