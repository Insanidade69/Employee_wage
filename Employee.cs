using System;
using System.Globalization;

namespace Employee_wage
{
    internal class Employee
    {
        public string Name;
        public double BruteWage;
        public double Tax;

        public double LiquidWage()
        {
            return BruteWage - Tax;
        }
        public void IncraseWage(double percent)
        {
            BruteWage = BruteWage + (BruteWage * percent / 100.0);
        }
        public override string ToString()
        {
            return "Employee " + Name + " Liquid wage: US$ " + LiquidWage().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
