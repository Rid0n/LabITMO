using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class ArraysTask2
    {
        private Dictionary<int, int> dict = new Dictionary<int, int>();
        private int[][] array;

        public static int ReadIntInput()
        {
            bool s = Int32.TryParse(Console.ReadLine(), out int input);
            while (!s)
            {
                Console.WriteLine("Invalid Format! Try again:");
                s = Int32.TryParse(Console.ReadLine(), out input);
            }
            return input;
        }
        
        public static int[] Read1DArrayOfInt()
        {
            Console.WriteLine("Please enter array elements separated by a space");
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
        public int GetMaxRecurringNumber()
        {
            //Dictionary<int,int> dict = new Dictionary<int, int>();
            for (int i = 0; i < array.Length; i++)
            {
                foreach (var value in array[i])
                {
                    if (dict.ContainsKey(value))
                        dict[value]++;
                    else
                        dict[value] = 1;
                }

            }

            int mv = -1;
            foreach (var pair in dict)
            {
                if (pair.Value > 1)
                {
                    mv = pair.Key;
                    break;
                }
            }
            foreach (var pair in dict)
            {
                if (pair.Value > 1)
                {
                    if (pair.Key > mv)
                    {
                        mv = pair.Key;
                    }

                }
            }
            return mv;
        }
        public int[][] Read2DArray()
        {
            Console.WriteLine("Morning! What is number of rows your array has?");
            int width = ReadIntInput();
            Console.WriteLine("Enter every row one by one");
            array = new int[width][];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Read1DArrayOfInt();
            }
            return array;
        }
        public int CountEmptyRows()
        {
            int counter = 0;                    //number of empty rows
            for (int i = 0; i < array.Length; i++)
            {
                int Sum=0;
                for (int j=0;j < array[i].Length;j++)
                {
                    Sum += array[i][j];
                }
                if (Sum == 0)
                {
                    counter++;
                }
            }
            return counter;                   //number of empty rows
           
        }
        public ArraysTask2(){
            array = Read2DArray();


            // mv - max value appearing more than once
            // Arrays task 2
            Console.WriteLine("Number of Empty rows: {0}", CountEmptyRows());
            int MRN = GetMaxRecurringNumber();
            if (MRN != -1)
            {
                Console.WriteLine("Largest number appearing more than once: {0}", GetMaxRecurringNumber());
            }
            else
            {
                Console.WriteLine("Largest number appearing more than once: there isn't one");
            }
        }
    }
}
