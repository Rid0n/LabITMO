using System;

using System.IO;

namespace Lab1
{
    class Strings
    {
        public string data;
        public void loadStringy()
        {
            Console.WriteLine("Please specify file path:");
            string path = Console.ReadLine();
            //string path = @"C:\Users\space\OneDrive\Рабочий стол\Лабы\hey.txt";
            data = File.ReadAllText(path);
        }
        public string[] split()
        { 
            string[] sentences;
            sentences = data.Split('.');
            if (sentences.Length > 0)
            {
                for (int i = 1; i < sentences.Length; i++)
                {
                    try
                    {
                        if (sentences[i].Length > 0)
                        {
                            sentences[i] = sentences[i].Remove(0, 1);
                        }
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        Console.WriteLine("wham!" + sentences[i] + "yopa");
                    }
                }

                return sentences;
            }
            else
            {
                return new string[] {"what"};
            }
        }
        public string[] reverse(string[] array)
        {
            for (int i = 0; i < array.Length/2; i++)
            {
                string temporal = array[i];
                array[i] = array[array.Length-i-1];
                array[array.Length - i-1] = temporal;
            }
            return array;
        }
        public string fix_up(string[] array)
        {
            string s = "";
            foreach (string item in array)
            {
                if (item != "")
                {
                    s += item + ". ";
                }
            }
            return s;
        }
    }
}
