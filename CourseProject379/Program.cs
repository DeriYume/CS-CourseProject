using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject379
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise 379
            RandomNumbers();
            Console.WriteLine("");

            FivePositiveNumbers();
            Console.WriteLine("");

            
            int comp = 0;

            Console.Write("How many random numbers do you want?    ");
            int sssk = int.Parse(Console.ReadLine());
            while (sssk < 0)
            {
                Console.WriteLine("Invalid number.");
                Console.Write("How many random numbers do you want?    ");
                sssk = int.Parse(Console.ReadLine());
            }

            comp = Sss(sssk);
            Console.Write("The product of random numbers from the list that have 2 digits and end with 5 is ");

            if (comp == 0)
            {
                Console.WriteLine("N/A. Couldn't find such numbers!");
            }
            else
            {
                Console.WriteLine(comp + ".");
            }


            Console.WriteLine("");
            Console.WriteLine("Assign POSITIVE values to a, b and c.");

            int a = 0; int b = 0; int c = 0;
                while (a <= 0)
                {
                    Console.Write("a = ");
                    a = int.Parse(Console.ReadLine());
                }
                while (b <= 0)
                {
                    Console.Write("b = ");
                    b = int.Parse(Console.ReadLine());
                }
                while (c <= 0)
                {
                    Console.Write("c = ");
                    c = int.Parse(Console.ReadLine());
                }
            
                Console.WriteLine("");
                int result1 = Sss(Math.Abs(c - b)); 
                int result2 = Sss(a + c);

                
                if (result1 != 0 && result2 != 0)
                {
                    Console.Write("Sss(|c - b|) * Sss(a + c) = ");
                    Console.WriteLine(result1 * result2);
                }
                else
                {
                    if (result1 == 0)
                    {
                        Console.WriteLine("Couldn't find numbers of interest in Sss(|c - b|).");
                    }
                    if (result2 == 0)
                    {
                        Console.WriteLine("Couldn't find numbers of interest in Sss(a + c).");
                    }
                }
            
        }

        public static void RandomNumbers()
        {

            Console.WriteLine("Random odd numbers in the interval [0; 150]: ");
            Random rnd = new Random();

            for (int i = 0; i < 132; i++)
            {
                int num = rnd.Next(0, 151);

                if (num % 2 != 0)
                {
                    Console.WriteLine(num);
                }
            }
        }

        public static void FivePositiveNumbers()
        {
            double product = 1;
            double result = 0;
            double number;

            Console.WriteLine("Enter 5 positive numbers");
            
            for (int i = 0; i < 5; i++)
            {
                number = double.Parse(Console.ReadLine());
                while (number <= 0)
                {
                    Console.WriteLine("Error! Please enter POSITIVE numbers!");
                    number = double.Parse(Console.ReadLine());
                }
                product = Math.Round((product * number), 2);
            }
            Console.WriteLine("The product of the numbers is {0}", product);
            result = Math.Round(Math.Pow(product, 1.0 / 5), 2);
            Console.WriteLine("5th root of the product is rounded to {0}", result);
        }

        public static int Sss(int k)
        {
            Random rndSss = new Random();
            int product = 1;

            for (int i = 0; i < k; i++)
            {
                int rndNum = rndSss.Next(0, 150); //assumed numbers are between 0 and 150
                Console.WriteLine(rndNum);

                if (rndNum >= 15 && rndNum <= 95 && rndNum / 10 > 0 && rndNum % 10 == 5) //checking if random number has 2 digit and ends with 5 
                {
                    product *= rndNum;
                }
            }

            if (product > 1)
            {
                return product;
            }
            else
            {
                return 0;
            }
        }
    }
}