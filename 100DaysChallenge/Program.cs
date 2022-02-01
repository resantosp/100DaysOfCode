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
    public static void solve(double meal_cost, int tip_percent, int tax_percent)
    {
        double new_tip_percent = ((double)tip_percent / (double)100) * (double)meal_cost;
        double new_tax_percent = ((double)tax_percent / (double)100) * (double)meal_cost;
        double result = Math.Round(meal_cost + new_tip_percent + new_tax_percent);
        Console.WriteLine(result);
    }
    static void Main()
    {
        double meal_cost = 12.00;

        int tip_percent = 20;

        int tax_percent = 8;

        solve(meal_cost, tip_percent, tax_percent);

    }
}