using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter marks (0-100): ");
        int marks = Convert.ToInt32(Console.ReadLine());

        if (marks < 0 || marks > 100)
        {
            Console.WriteLine("Invalid Marks");
        }
        else if (marks >= 91)
        {
            Console.WriteLine("Grade: O");
        }
        else if (marks >= 81)
        {
            Console.WriteLine("Grade: A+");
        }
        else if (marks >= 71)
        {
            Console.WriteLine("Grade: A");
        }
        else if (marks >= 61)
        {
            Console.WriteLine("Grade: B+");
        }
        else if (marks >= 51)
        {
            Console.WriteLine("Grade: B");
        }
        else if (marks < 50)
        {
            Console.WriteLine("Fail");
        }
        else
        {
            Console.WriteLine("Grade not specified for 50 marks");
        }
    }
}
