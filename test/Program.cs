using System;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string destination = Console.ReadLine();
                if (destination == "End")
                {
                    break;
                }
                double sum = 0;
                double budget = double.Parse(Console.ReadLine());
                while (budget > sum)
                {
                    double sumInput = double.Parse(Console.ReadLine());
                    sum += sumInput;
                }
                Console.WriteLine($"Going to {destination}!");
            }
        }
    }
}
