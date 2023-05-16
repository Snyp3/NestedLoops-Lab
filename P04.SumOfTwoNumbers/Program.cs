using System;

namespace P04.SumOfTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            bool comboFound = false;
            int count = 0;
            int a = 0, b = 0;
            for ( a = start; a <= end; a++)
            { 
                for ( b = start; b <= end; b++)
                {
                    count++;
                    if (a + b == magicNumber)
                    {
                        
                        comboFound = true;
                        break;
                    }
                }
                if (comboFound)
                    {
                        break;
                    }
            }
            if (comboFound)
            {
                Console.WriteLine($"Combination N:{count} ({a} + {b} = {magicNumber})");
            }
            else
            {
                Console.WriteLine($"{count} combinations - neither equals {magicNumber}");
            }
        }

    }
}
