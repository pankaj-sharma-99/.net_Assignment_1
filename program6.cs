using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Even Numbers:");

        for (int i = 1; i <= n; i++)
        {
            if (i % 2 == 0)
                Console.Write(i + " ");
        }

        Console.WriteLine("\nOdd Numbers:");

        for (int i = 1; i <= n; i++)
        {
            if (i % 2 != 0)
                Console.Write(i + " ");
        }
    }
}
