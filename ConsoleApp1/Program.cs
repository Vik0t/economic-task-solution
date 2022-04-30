using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Calculate(Console.ReadLine()));
        }
        static double Calculate(string input)
        {
            string[] elements = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            double value = double.Parse(elements[0]);
            double percent = double.Parse(elements[1]);
            double days = double.Parse(elements[2]);

            double summary = value * Math.Pow(percent / 100 / 12 + 1, days);
            return summary;
        }
    }
}
