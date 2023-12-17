namespace Task_2;

public class MathOperations
{
    public static double Add(double a, double b)
    {
        return a + b;
    }


    public static double Add(double[] numbers)
    {
        double sum = 0;
        foreach (double num in numbers)
        {
            sum += num;
        }
        return sum;
    }

    public static double Subtract(double a, double b)
    {
        return a - b;
    }


    public static double Multiply(double a, double b)
    {
        return a * b;
    }

    public static double Divide(double a, double b)
    {
        if (b != 0)
        {
            return a / b;
        }
        else
        {
            throw new DivideByZeroException();
        }
    }
}
