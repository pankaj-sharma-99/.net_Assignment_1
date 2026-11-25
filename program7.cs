using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a positive integer: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n < 0 || n > 20)
        {
            Console.WriteLine("Enter a number between 0 and 20");
            return;
        }

        long factorial = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial = factorial * i;
        }

        Console.WriteLine("Factorial = " + factorial);
    }
}
