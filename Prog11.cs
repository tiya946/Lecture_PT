using System;

class Prog11
{
    static void Main()
    {
        int n = 5; // You can change this value for a bigger or smaller diamond

        // Upper half (including middle row)
        for (int i = 1; i <= n; i++)
        {
            // Print spaces
            for (int j = i; j < n; j++)
                Console.Write(" ");
            // Print stars
            for (int j = 1; j <= (2 * i - 1); j++)
                Console.Write("*");
            Console.WriteLine();
        }

        // Lower half
        for (int i = n - 1; i >= 1; i--)
        {
            // Print spaces
            for (int j = n; j > i; j--)
                Console.Write(" ");
            // Print stars
            for (int j = 1; j <= (2 * i - 1); j++)
                Console.Write("*");
            Console.WriteLine();
        }
    }
}
