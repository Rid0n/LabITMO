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
        
        public static int[] Read1DArrayOfInt(int columns)
        {
            Console.WriteLine("Please enter array elements separated by a space");
            string[] s = Console.ReadLine().Split(" ");
            bool flag = s.Length == columns;
            while (!flag) {
                Console.WriteLine("Number of elements does not equal the number of columns, try again.");
                Console.WriteLine("Please enter array elements separated by a space");
                s = Console.ReadLine().Split(" ");
                flag = s.Length == columns;
            }
            
            int[] d = new int[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                bool r = int.TryParse(s[i], out d[i]);
                while (!r)
                {
                    Console.WriteLine("{0} is not an integer, please reenter it.",s[i]);
                    r = int.TryParse(Console.ReadLine(), out d[i]);
                }

            }
            return d;

            
            
            
        }
        public int GetMaxRecurringNumber()
        {
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
                //Console.WriteLine("Num {0}, appearances {1}" , pair.Key,pair.Value);
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
            Console.WriteLine("What is the number of rows of your array?");
            int width = ReadIntInput();
            Console.WriteLine("the number of columns?");
            int columns = ReadIntInput();
            Console.WriteLine("Enter every row one by one");
            array = new int[width][];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Read1DArrayOfInt(columns);
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
                Console.WriteLine("Largest number appearing more than once: {0}", MRN);
            }
            else
            {
                Console.WriteLine("Largest number appearing more than once: there isn't one");
            }
        }
    }
}
