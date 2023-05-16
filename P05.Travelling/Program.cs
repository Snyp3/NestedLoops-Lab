using System;
using System.ComponentModel;

namespace P05.Travelling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string goingTo = Console.ReadLine();
                if (goingTo == "End")
                {
                    break;
                }
                double currnetBudget = 0;
                double budgetNeedet = double.Parse(Console.ReadLine());
                while (budgetNeedet > currnetBudget)
                {
                    double savings = double.Parse(Console.ReadLine());
                    currnetBudget += savings;
                }
                Console.WriteLine($"Going to {goingTo}!");

            }
        }
    }
}
