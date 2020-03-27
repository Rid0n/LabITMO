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
            Console.WriteLine("Please enter the spaced out array");
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
        public static int[] read1DArrayOfInt()
        {
            Console.WriteLine("Please enter the spaced out array");
            string[] s = Console.ReadLine().Split(" ");
            int[] d = new int[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                bool r = int.TryParse(s[i], out d[i]);
                if (!r)
                {
                    Console.WriteLine("Invalid format! Try entering array again:");
                    i = -1;
                    s = Console.ReadLine().Split(" ");
                    d = new int[s.Length];
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
            //graph_function();
            //                        // piece-wise function

            //hit_function();
            //                    // hit function



            //Console.WriteLine("Morning! What is the width of your array?");
            //int width = (int)readDoubleInput();
            //Console.WriteLine("Enter every row line by line");
            //int[][] array = new int[width][];
            //int counter = 0;                    //number of empty rows
            //for (int i = 0; i < width; i++)
            //{
            //    array[i] = read1DArrayOfInt();
            //    if (array[i].Length == 0)
            //    {
            //        counter++;
            //    }

            //}

            ////int[] array = { 10, 5, 10, 2, 2, 3, 4, 5, 5, 6, 7, 8, 9, 11, 12, 12 };
            //var dict = new Dictionary<int, int>();
            //for (int i = 0; i < array.Length; i++)
            //{
            //    foreach (var value in array[i])
            //    {
            //        if (dict.ContainsKey(value))
            //            dict[value]++;
            //        else
            //            dict[value] = 1;
            //    }

            //}

            //int mv=-1;
            //foreach (var pair in dict)
            //{
            //    if (pair.Value > 1)
            //    {
            //        mv = pair.Key;
            //        break;
            //    }
            //}
            //foreach (var pair in dict)
            //{
            //    if (pair.Value > 1)
            //    {
            //        if (pair.Key > mv)
            //        {
            //            mv = pair.Key;
            //        }

            //    }
            //}                           // mv - max recurring value
            //                                                                // Arrays task 2

            //double[] arr = read1DArray();
            //arrayer Arr = new arrayer(arr);
            //Arr.arrayThingify(); // neccessary to achieve desired results
            //Console.WriteLine(Arr.Product); // product of inbetween numbers
            //Console.WriteLine(Arr.Sum); // sum of required numbers
            //Arr.sort();
            //                                                               // Arrays task 1

            //Strings s = new Strings();
            //s.loadStringy();
            //Console.WriteLine(s.fix_up(s.reverse(s.split()))); // prints reversed sentences
            //                                                               //Strings task


            Calculator c = new Calculator();
            // Calculator
        }
    }
}
