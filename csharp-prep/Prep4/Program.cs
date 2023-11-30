using System;
using System.Collections.Generic;

namespace Prep4
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            int input;
            
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");

            do
            {
                Console.Write("Enter number: ");
                input = Convert.ToInt32(Console.ReadLine());

                if (input != 0)
                {
                    numbers.Add(input);
                }
            } while (input != 0);

            if (numbers.Count > 0)
            {
                int sum = 0;
                int max = numbers[0];
                
                foreach (int num in numbers)
                {
                    sum += num;
                    if (num > max)
                    {
                        max = num;
                    }
                }

                double average = (double)sum / numbers.Count;

                Console.WriteLine("The sum is: " + sum);
                Console.WriteLine("The average is: " + average);
                Console.WriteLine("The largest number is: " + max);
            }
            else
            {
                Console.WriteLine("No numbers entered.");
            }

            Console.ReadLine();
        }
    }
}
