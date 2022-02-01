using System;
class Program
{
    static void DayZero()
    {
        string inputString = "Hello, World!";
        Console.WriteLine(inputString);
    }
    static void DayOne()
    {
        // Declare second integer, double, and String variables.
        int intNumber, i;
        double doubleNumber, d;
        string text, s;
        // Read and save an integer, double, and String to your variables.
        intNumber = int.Parse(Console.ReadLine());
        doubleNumber = double.Parse(Console.ReadLine());
        text = Console.ReadLine();

        i = int.Parse(Console.ReadLine());
        d = double.Parse(Console.ReadLine());
        s = Console.ReadLine();
        
        // Print the sum of both integer variables on a new line.
        Console.WriteLine(i + intNumber);
        
        // Print the sum of the double variables on a new line.
        Console.WriteLine("{0:F1}", d + doubleNumber);
        
        // Concatenate and print the String variables on a new line
        // The 's' variable above should be printed first.
        Console.WriteLine(s + text);
    }
    static void Main()
    {
        

    }
}