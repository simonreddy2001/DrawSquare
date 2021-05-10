using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Enter a number:");
            int userValue = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= userValue; i++)
            {
                for (int j = 1; j <= userValue; j++)
                {
                    if (i == 1 || i == userValue || j == 1 || j == userValue)
                    {
                        Console.Write(" *");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
            
        }

    }
}
