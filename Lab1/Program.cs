using System;
using System.Collections;
using System.Collections.Generic;
using static System.Math;
namespace Lab1
{

    class Program
    {
        public static double readDoubleInput()
        {
            bool s = Double.TryParse(Console.ReadLine(), out double input);
            while (!s)
            {
                Console.WriteLine("Invalid Format! Try again:");
                s = Double.TryParse(Console.ReadLine(), out input);
            }
            return input;
        }
        public static double[] read1DArray()
        {
            Console.WriteLine("Please enter array elements separated by a space");
            string[] s = Console.ReadLine().Split(" ");
            double[] d = new double[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                bool r = double.TryParse(s[i], out d[i]);
                if (!r)
                {
                    Console.WriteLine("Invalid format! Try entering array again:");
                    i = -1;
                    s = Console.ReadLine().Split(" ");
                    d = new double[s.Length];
                }

            }
            return d;
        }

        public static double function(double input)
        {
            return 2 * Pow(Sin(3 * PI - 2 * input), 2) * Pow(Cos(5 * PI + 2 * input), 2);
        }
        public static void graph_function() 
        {
            double input = readDoubleInput();
            int R = 3;
            if (input < -10 | input > 9)
            {
                Console.WriteLine("Given value exists outside of function boundaries");    
            }
            else if (input < -6)
            {
                Console.WriteLine( -Sqrt(Pow(R, 2) - Pow(input, 2)));
            }
            else if (input < -3)
            {
                Console.WriteLine(input + 3);
            }
            else if (input < 0)
            {
                Console.WriteLine(Sqrt(Pow(R, 2) - Pow(input, 2)));
            }
            else if (input < 3)
            {
                Console.WriteLine(-input + 3);
            }
            else 
            {
                Console.WriteLine(input / 3);
            }

        }
        public static bool hit_function()
        {
            Console.WriteLine("Please specify point X coordinate:");
            double X = readDoubleInput();
            Console.WriteLine("Please specify point Y coordinate:");
            double Y = readDoubleInput();
            Console.WriteLine("Specify radius:");
            double radius = readDoubleInput();

            double y = CopySign(Sqrt(Pow(radius, 2) - Pow(X, 2)), X);
            if (X > 0)
            {
                if (Y < y && Y >= Tan(PI / 4) * X)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (Y > y && Y <= Tan(PI / 4) * X)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static double taylor(double input, double n)
        {
            double taylor_sum = 0;
            for (int i = 0; i < n; i++)
            {
                taylor_sum += Pow(-1, n) * Pow(input, n + 1) / (n + 1);
            }
            return taylor_sum;

            // unfinished
        }

        static void Main(string[] args)
        {



            ArraysTask2 p = new ArraysTask2();

            //Strings s = new Strings();
                                            



        }
    }
}
