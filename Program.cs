using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_PT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i<=5; i++)
            {
                for(int j = 1; j<= 5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();



            for (int i = 1; i <=5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();



            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();



            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();




            for (int i = 1; i <= 9; i++)
            {
                int t = i <= 5 ? i : 10 - i;
                for (int j = 1; j <= t; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();



            for (int i = 5; i >= 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 5; j >= i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            // for tables of 1 to 10 :
            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 1; j <= 10; j++)
            //    {
            //        int ans = (i*j);
            //        Console.WriteLine($" {i} * {j} = " + ans);
            //    }
            //}
            //Console.WriteLine();



        }
    }
}
