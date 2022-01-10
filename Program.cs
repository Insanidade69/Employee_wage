using System;
using System.Globalization;

namespace Employee_wage
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee func = new Employee();

            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-= Employee Wage =-=-=-=-=-=-=-=-=-=-=-=-=-");
            Console.WriteLine("What is name of employee?");
            Console.Write("Name: ");
            func.Name = Console.ReadLine();

            Console.WriteLine(" ");

            Console.WriteLine("What is brute wage of employee?");
            Console.Write("Brute Wage: USS$ ");
            func.BruteWage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(" ");

            Console.WriteLine("What is the tax?");
            Console.Write("Tax: US$ ");
            func.Tax = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");

            Console.WriteLine(func);

            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");

            Console.WriteLine("What the percent wo u want incrase?");
            Console.Write("Percent: ");
            double percent = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            func.IncraseWage(percent);

            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");

            Console.WriteLine(func);
        }
    }
}