using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject48a
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise 48 а)
            Console.Write("x = ");
            int x = int.Parse(Console.ReadLine());
            double y;
            if (x <= 0)
            {
                y = 5 * x + 1;
                Console.WriteLine("y = 5 * x + 1");
                Console.WriteLine("y = {0}", y);
            }
            else 
            {
                y = 1 - x;
                Console.WriteLine("y = 1 - x");
                Console.WriteLine("y = {0}", y);
            }
        }
    }
}
