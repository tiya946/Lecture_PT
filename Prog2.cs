using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_PT
{
    internal class Prog2
    {
        public static void Main(string[] args)
        {
            int a = 5;
            int b = 5;
            int res = a++ + b++;
            //res = a;
            //a = a + 1;
            Console.WriteLine(res);
        }
    }
}
