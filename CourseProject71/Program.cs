using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject71
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test 1 - 7 I)
            Console.WriteLine("Truncated Cone Volume V Calculator");
            Console.WriteLine("");

            double H = 0; double R = 0; double r = 0;
            Console.WriteLine("Assign positive values to the height H, the base radius R and the surface radius r.");
            while (H <= 0)
            {
                Console.Write("Height H: ");
                H = double.Parse(Console.ReadLine());
            }
            while (R <= 0)
            {
                Console.Write("Base radius R: ");
                R = double.Parse(Console.ReadLine());
            }
            while (r <= 0)
            {
                Console.Write("Surface radius r: ");
                r = double.Parse(Console.ReadLine());

            }


            if (R < r)
            {
                Console.WriteLine("The base radius has to be bigger than the surface radius!!!");
            }
            else
            {       double V = Math.Round(Math.PI * H * (Math.Pow(R, 2) + R * r + Math.Pow(r, 2)) / 3, 2);
                    Console.WriteLine("The volume V is rounded to " + V);
            }
        }
    }
}
