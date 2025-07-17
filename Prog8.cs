using System;
namespace Lecture_PT
{
    class Prog9
    {
        static void Main()
        {
            Console.Write("Enter a number : ");
            int n = int.Parse(Console.ReadLine());

            // Top border
            for (int i = 0; i < 3; i++)
            { Console.Write(n + " "); }
            Console.WriteLine();

            // Middle rows
            for (int i = 1; i < n; i++)
            {
                Console.Write(n + " ");
                Console.Write(i + " ");
                Console.Write(n + " ");
                Console.WriteLine();
            }

            // Bottom border
            for (int i = 0; i < 3; i++)
                Console.Write(n + " ");
            Console.WriteLine();
        }
    }
}

/*
 *
 #  *
 *  #  *
 #  *  #  *
 *  #  *  #  *
 
 
 
 */