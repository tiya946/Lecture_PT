using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_PT
{
    internal class prog7
    {
       
        public static void Main()
        {
            int n = 11; // Total terms to print (based on your example)

            int first = 0, second = 1, next;

            Console.Write(first + " " + second + " ");

            for (int i = 2; i < n; i++)
            {
                next = first + second;
                Console.Write(next + " ");
                first = second;
                second = next;
            }

            Console.WriteLine();
        }
    }
}
