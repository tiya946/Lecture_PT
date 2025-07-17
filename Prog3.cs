
using System;

namespace Lecture_PT
{
    class Prog3
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the digit to use in pattern (e.g., 5): ");
            int digit = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of terms: ");
            int n = int.Parse(Console.ReadLine());

            int term = 0;
            int sum = 0;

            Console.Write("Pattern: ");
            for (int i = 1; i <= n; i++)
            {
                term = term * 10 + digit;
                Console.Write(term);
                if (i != n)
                    Console.Write(" + ");
                sum += term;
            }

            Console.WriteLine($"\nSum of the series: {sum}");
        }
    }
}
