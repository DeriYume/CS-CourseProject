using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject413
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise 413
            Console.Write("Please eneter the size of the array (int): ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            double[] A = new double[n];
            double[] B = new double[n];
            double[] C = new double[n];

            Console.WriteLine("Array A: ");
            InputArray(A);
            Console.WriteLine("The AVG of indexes of interest is {0}.", AVG(A));
            Console.WriteLine("");
            Console.WriteLine("Array B: ");
            InputArray(B);
            Console.WriteLine("The AVG of indexes of interest is {0}.", AVG(B));
            Console.WriteLine("");
            Console.WriteLine("Array C:");
            InputArray(C);
            Console.WriteLine("The AVG of indexes of interest is {0}.", AVG(C));
            Console.WriteLine("");


            double[] RMS = { AVG(A), AVG(B), AVG(C) };
            Console.WriteLine("RMS: " + RMS_Value(RMS));
            Console.WriteLine("");

            C = ReCal(A, B);
            Console.Write("New C: ");
            for (int i = 0; i < C.Length; i++)
            {
                if (i == 0) Console.Write("{ ");

                Console.Write(C[i]);
                if (i != C.Length - 1) Console.Write(", ");

                if (i == C.Length - 1) Console.Write(" }");
            }

            Console.WriteLine("");
        }

        static void InputArray(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Array[{0}] = ", i);
                array[i] = double.Parse(Console.ReadLine());
            }
        }

        static double AVG(double[] array)
        {
            double sum = 0;
            int counter = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (i % 3 == 0)
                {
                    sum += array[i];
                    counter++;
                }
            }

            if (counter == 0)
            {
                Console.WriteLine("N/A");
                return 0;
            }
            else
            {
                return (double)sum / counter;
            }
        }

        static double RMS_Value(double[] array)
        {
            double square = 0;
            double mean, root = 0;
 
            // Calculate square
            for (int i = 0; i < array.Length; i++)
            {
                square += Math.Pow(array[i], 2);
            }
 
            // Calculate Mean
            mean = (square / (array.Length));
 
            // Calculate Root
            root = Math.Round(Math.Sqrt(mean), 2);
 
            return root;
        }

        static double[] ReCal(double[] a, double[] b)
        {
            double[] x = new double[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                x[i] = Math.Pow(a[a.Length - i - 1], 2) + Math.Pow(b[i], 4);
            }
            return x;
        }
    }
}
