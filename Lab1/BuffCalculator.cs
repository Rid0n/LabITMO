using System;
using System.Collections.Generic;
using System.Text;



namespace Lab1
{
    class Calculation
    {
        public double result { get; private set; } // dictionary?
        public string expression { get; private set; } // not string
        public int step { get; private set; }
    }
    class BuffCalculator
    {
        public void DisplayTips()
        {
            Console.WriteLine("Usage:");
            Console.WriteLine("when first symbol on line is ‘>’ – enter operand(number)");
            Console.WriteLine("when first symbol on line is ‘@’ – enter operation");
            Console.WriteLine("operation is one of ‘+’, ‘-‘, ‘/’, ‘*’ or");
            Console.WriteLine("‘#’ followed with number of evaluation step ‘q’ to exit");
        }

        Dictionary<int, double> dict = new Dictionary<int, double>();
        bool flag = true;
        public BuffCalculator()
        {
            DisplayTips();

            Console.WriteLine(">:");
            double n = Program.readDoubleInput();
            double operand;
            int k = 1;
            Console.WriteLine("#{0}:{1}", k, n);
            dict.Add(1, n);
            while (flag)
            {
                Console.WriteLine("@:");
                string line = Console.ReadLine();
                Console.WriteLine(">:");
                switch (line)
                {
                    case "+":
                        operand = Program.readDoubleInput();
                        n += operand;
                        goto default;
                    case "-":
                        operand = Program.readDoubleInput();
                        n -= operand;
                        goto default;
                    case "/":
                        operand = Program.readDoubleInput();
                        n /= operand;
                        goto default;
                    case "*":
                        operand = Program.readDoubleInput();
                        n *= operand;
                        goto default;
                    case "q":
                        flag = false;
                        break;
                    default:
                        if (line[0] == '#')
                        {
                            bool r = int.TryParse(line.Remove(0, 1), out int key);
                            if (key <= dict.Count && r) n = dict[key];

                        }
                        k++;
                        Console.WriteLine("#{0}:{1}", k, n);
                        dict.Add(k, n);
                        break;
                }
            }
        }

    }
}
