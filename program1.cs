using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter Student Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Roll Number: ");
        int rollNo = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Marks: ");
        double marks = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\n----- Student Details -----");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Roll Number: " + rollNo);
        Console.WriteLine("Marks: " + marks);
    }
}
