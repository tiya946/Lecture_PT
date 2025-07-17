using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_PT
{
    internal class Prog10
    {
        public static void Main(string[] args)
        {
           
                Console.Write("Enter number of rows: ");
                int rows = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= rows; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        if ((i + j) % 2 == 0)
                            Console.Write("* ");
                        else
                            Console.Write("# ");
                    }
                    Console.WriteLine();
                }
        }
    }

}
