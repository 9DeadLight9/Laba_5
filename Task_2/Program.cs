using Task_2;

class Program
{
    static void Main(string[] args)
    {
     
        double[] numbers = { 1.0, 2.0, 3.0, 4.0, 5.0 };

       
        Console.WriteLine("Сума 5 і 10: " + MathOperations.Add(5, 10));

    
        Console.WriteLine("Сума чисел масиву: " + MathOperations.Add(numbers));

       
        Console.WriteLine("Різниця 10 і 5: " + MathOperations.Subtract(10, 5));

    
        Console.WriteLine("Добуток 5 і 10: " + MathOperations.Multiply(5, 10));

        
        Console.WriteLine("Частка 10 і 5: " + MathOperations.Divide(10, 5));
    }
}
