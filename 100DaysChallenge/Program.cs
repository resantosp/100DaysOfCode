using System;
using DaysChallenge;
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
        //Usando cast (double) para fazer corretamente a divisão de forma que retorne um double
        double new_tip_percent = ((double)tip_percent / (double)100) * meal_cost;
        double new_tax_percent = ((double)tax_percent / (double)100) * meal_cost;
        double result = Math.Round(meal_cost + new_tip_percent + new_tax_percent);
        Console.WriteLine(result);
    }
    public static int factorial(int n)
    {
        //Base case
        if (n <= 0)
        {
            return 1;
        }
        //Recursive case
        return n * factorial(n - 1);
    }
    static void DayTwo()
    {
        double meal_cost = 12.00;

        int tip_percent = 20;

        int tax_percent = 8;

        solve(meal_cost, tip_percent, tax_percent);
    }

    static void DayThree()
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        if (n % 2 != 0)
        {
            System.Console.WriteLine("Weird");
        }
        else if (n % 2 == 0 && n >= 2 && n <= 5)
        {
            System.Console.WriteLine("Not Weird");
        }
        else if (n % 2 == 0 && n >= 6 && n <= 20)
        {
            System.Console.WriteLine("Weird");
        }
        else
        {
            System.Console.WriteLine("Not weird");
        }
    }
    static void DayFour()
    {
        int T = int.Parse(Console.In.ReadLine());
        for (int i = 0; i < T; i++) 
        {
            int age = int.Parse(Console.In.ReadLine());
            Person p = new Person(age);
             p.amIOld();
                for (int j = 0; j < 3; j++) 
                {
                  p.yearPasses();
                }
                p.amIOld();
                Console.WriteLine();
        }
    }
    static void DayFive()
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        for (int i = 1; i <= 10; i++)
        {
            int resultado = n * i;
            System.Console.WriteLine($"{n} x {i} = {resultado}");
        }
    }
    static void DaySix()
    {
        int t = Convert.ToInt32(Console.ReadLine().Trim());
        
        while (t > 0)
        {
            string s = Console.ReadLine();

            int n = s.Length;

            for (int i = 0; i <= n - 1; i++)
            {
                if (i == 0 || i % 2 == 0)
                {
                    Console.Write($"{s[i]}");
                }
            }

            Console.Write(" ");

            for (int i = 0; i <= n - 1; i++)
            {
                if (i != 0 && i % 2 != 0)
                {
                    Console.Write($"{s[i]}");
                }
            }
            
            Console.WriteLine();
            t -= 1;
            
        }
        static void DaySeven()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            arr.Reverse();

            foreach (var numero in arr)
            {
                Console.Write($"{numero} ");
            }
        }
        static void DayEight()
        {
            //Phone Book Dictionary
            int entries = Convert.ToInt32(Console.ReadLine());
            Dictionary<string, string> phoneNumber = new Dictionary<string, string>(entries);

            while (entries > 0)
            {
                string s = Console.ReadLine();
                string[] subs = s.Split(' ');
                phoneNumber.Add(subs[0], subs[1]);
                entries -= 1;
            }

            string names = "first";

            while (!string.IsNullOrEmpty(names))
            {
                names = Console.ReadLine();


                if (phoneNumber.ContainsKey(names))
                {
                    System.Console.WriteLine($"{names}={phoneNumber[names]}");
                }
                else
                {
                    System.Console.WriteLine("Not Found");
                }
            }
        }
        static void DayNine()
        {
            //Factorial
            int n = Convert.ToInt32(Console.ReadLine());

            int fact = factorial(n);

            System.Console.WriteLine(fact);
        }
    }
    static void Main()
    {
        
        

    }
}