using System;

namespace _09._Longer_Line
{
    class Program
    {
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            GetLongerLine(x1, y1, x2, y2, x3, y3, x4, y4);

        }

        private static void GetLongerLine(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            double line1 = CalculatePythagorean(Math.Pow(x2 - x1, 2), Math.Pow(y2 - y1, 2));
            double line2 = CalculatePythagorean(Math.Pow(x4 - x3, 2), Math.Pow(y4 - y3, 2));

            if (line1 >= line2)
            {
                PrintCloserLine(x1, y1, x2, y2);
            }
            else
            {
                PrintCloserLine(x3, y3, x4, y4);
            }
        }

        public static void PrintCloserLine(double x1, double y1, double x2, double y2)
        {

            double line1 = CalculatePythagorean(x1, y1);
            double line2 = CalculatePythagorean(x2, y2);

            if (line1 <= line2)
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }

        }

        static double CalculatePythagorean(double x, double y)
        {
            double result = Math.Sqrt(x * x + y * y);

            return result;
        }

    }
}

