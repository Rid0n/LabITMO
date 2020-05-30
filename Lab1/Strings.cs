using System;

using System.IO;

namespace Lab1
{
    class Strings
    {
        private string data;
        public Strings()
        {
            loadStringie();
            printReversed();  
        }
        public void loadStringie()
        {
            Console.WriteLine("Please specify file path:");
            //string path = Console.ReadLine();
            string path = @"C:\Users\space\OneDrive\Рабочий стол\Лабы\hey.txt";
            data = File.ReadAllText(path);
        }
        public string[] Split()
        {
            
            int numberOfSentences = 0;
            foreach (char item in data)
            {
                if (item == '?' || item == '!' || item == '.'){
                    numberOfSentences++;
                }
            }
            int p = 0;
            string[] sentences = new string[numberOfSentences];
            for (int i = 0; i < data.Length; i++)
                switch (data[i])
                {
                    case '.':
                        string cutData = data.Remove(i) + '.';
                        sentences[p] = cutData[0] == ' ' ? cutData.Substring(1) : cutData;
                        data = data.Substring(i + 1);
                        i = 0;
                        p++;
                        break;
                    case '!':
                        cutData = data.Remove(i) + '!';
                        sentences[p] = cutData[0] == ' ' ? cutData.Substring(1) : cutData;
                        data = data.Substring(i+1);
                        i = 0;
                        p++;
                        break;
                    case '?':
                        cutData = data.Remove(i) + '?';
                        sentences[p] =( cutData[0] == ' ' ? cutData.Substring(1): cutData);
                        data = data.Substring(i + 1);
                        i = 0;
                        p++;
                        break;
                }
            return sentences;
        }
        public string[] Reverse(string[] array)
        {
            for (int i = 0; i < array.Length/2; i++)
            {
                string temporal = array[i];
                array[i] = array[array.Length-i-1];
                array[array.Length - i-1] = temporal;
            }
            return array;
        }
       
        public void printReversed()
        {
            foreach (string item in Reverse(Split()))
            {
                Console.WriteLine(item);
            }
        }
        public void printReversed(string[] str)
        {
            foreach (string item in str)
            {
                Console.WriteLine(item);
            }
        }
    }
}
