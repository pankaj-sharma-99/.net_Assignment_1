using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Sum = " + (a + b));
        Console.WriteLine("Difference = " + (a - b));
        Console.WriteLine("Product = " + (a * b));

        if (b != 0)
        {
            Console.WriteLine("Quotient = " + (a / b));
            Console.WriteLine("Remainder = " + (a % b));
        }
        else
        {
            Console.WriteLine("Division by zero is not possible.");
        }
    }
}
