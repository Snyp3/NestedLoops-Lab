using System;

namespace P06.Building
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int floor = int.Parse(Console.ReadLine());
            int apartment = int.Parse(Console.ReadLine());

            for (int currentFl = floor ; currentFl >= 1; currentFl--)
            {

                for (int currAp = 0; currAp < apartment; currAp++)
                {
                    if (currentFl == floor)
                    {
                        Console.Write($"L{currentFl}{currAp} ");
                    }

                    else if (currentFl % 2 == 0)
                    {
                        Console.Write($"O{currentFl}{currAp} ");
                        
                    }
                    else
                    {
                        Console.Write($"A{currentFl}{currAp} ");
                        
                    }
                }

                Console.WriteLine();

            }

        }
    }
}
