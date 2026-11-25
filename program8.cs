using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        bool isPrime = n > 1;

        for (int i = 2; i <= n / i && isPrime; i++)
        {
            if (n % i == 0)
            {
                isPrime = false;
            }
        }

        if (isPrime)
            Console.WriteLine("Prime Number");
        else
            Console.WriteLine("Not Prime Number");
    }
}
