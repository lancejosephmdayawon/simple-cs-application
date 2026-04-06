using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Student Grade Calculator ===");

        // Ask for student name
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        // Input grades
        Console.Write("Enter grade in Math: ");
        double math = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter grade in English: ");
        double english = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter grade in Science: ");
        double science = Convert.ToDouble(Console.ReadLine());

        // Calculate average
        double average = (math + english + science) / 3;

        // Display results
        Console.WriteLine("\n--- Result ---");
        Console.WriteLine("Student Name: " + name);
        Console.WriteLine("Average Grade: " + average.ToString("F2"));

        // Determine pass or fail
        if (average >= 75)
        {
            Console.WriteLine("Status: Passed");
        }
        else
        {
            Console.WriteLine("Status: Failed");
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}