using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject209g
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise 209 g)
            int lowest = 0;
            int highest = 0;

            Random rnd = new Random();


            Console.WriteLine("Starred numbers have remainder 1 after division by 7.");
            Console.WriteLine("");
            for (int i = 1; i <= 100; i++)
            {

                int num = rnd.Next(0, 133);

                if (num % 7 == 1)
                {
                    Console.WriteLine(" * " + num + " * ");
                }
                else
                {
                    Console.WriteLine(num);
                }

                //some extra info
                if (lowest > num) lowest = num;
                if (highest < num) highest = num;

            }
            Console.WriteLine("");
            Console.WriteLine("Some extra info: ");
            Console.WriteLine("Lowest number: {0}", lowest);
            Console.WriteLine("Highest number: {0}", highest);
        }
    }
}