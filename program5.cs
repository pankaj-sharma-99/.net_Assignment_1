using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");

        Console.Write("Enter your choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("Result = " + (a + b));
                break;

            case 2:
                Console.WriteLine("Result = " + (a - b));
                break;

            case 3:
                Console.WriteLine("Result = " + (a * b));
                break;

            case 4:
                if (b != 0)
                    Console.WriteLine("Result = " + (a / b));
                else
                    Console.WriteLine("Cannot divide by zero");
                break;

            default:
                Console.WriteLine("Invalid Choice");
                break;
        }
    }
}
