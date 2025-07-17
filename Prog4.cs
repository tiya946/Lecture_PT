using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_PT
{
    internal class Prog4
    {
        public static void Main(string[] args)
        {

            int[] arr = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Array elements:");
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
        }
    }
}
