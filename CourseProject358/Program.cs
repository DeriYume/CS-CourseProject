using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject358
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise 358
            Console.WriteLine("Input your names: ");
            string input = Console.ReadLine();
            StringBuilder result = new StringBuilder();

            List<string> names = input.Split(' ').ToList();

            if (names.Count < 3)
            {
                Console.WriteLine("You need to input minimum three names!");
            }
            else
            {
                for (int i = 0; i < names.Count - 1; i++)
                {
                    if (i == 0 || i == 1)
                    {
                        string name = names[i];
                        result.Append(name[0].ToString() + '.');
                    }
                }
                result.Append(" " + names[names.Count - 1]);
                Console.WriteLine(result);
            }
        }
    }
} 