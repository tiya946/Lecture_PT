using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_PT
{
    internal class Prog9
    {
        public static void Main()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            int originalNumber = number;
            int sum = 0;

            // Count the number of digits
            int digits = number.ToString().Length;

            while (number > 0)
            {
                int digit = number % 10;
                sum += (int)Math.Pow(digit, digits);
                number /= 10;
            }

            if (sum == originalNumber)
                Console.WriteLine(originalNumber + " is an Armstrong number.");
            else
                Console.WriteLine(originalNumber + " is not an Armstrong number.");
        }
    }

}

