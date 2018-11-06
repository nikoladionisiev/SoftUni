using System;

namespace _11._Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();

            double area = 0.0;

            if (figureType == "triangle")
            {
                double firstParameter = double.Parse(Console.ReadLine());
                double secondParameter = double.Parse(Console.ReadLine());

                area = GetTriangleArea(firstParameter, secondParameter);
            }

            else if (figureType == "square")
            {
                double firstParameter = double.Parse(Console.ReadLine());

                area = GetSquareArea(firstParameter);
            }

            else if (figureType == "rectangle")
            {
                double firstParameter = double.Parse(Console.ReadLine());
                double secondParameter = double.Parse(Console.ReadLine());

                area = GetRectangleArea(firstParameter, secondParameter);
            }

            else if (figureType == "circle")
            {
                double firstParameter = double.Parse(Console.ReadLine());

                area = GetCircleArea(firstParameter);
            }

            Console.WriteLine($"{area :f2}");   


        }

        public static double GetTriangleArea(double firstParameter, double secondParameter)
        {
            double area = (firstParameter * secondParameter) / 2;

            return area;
        }

        public static double GetSquareArea(double firstParameter)
        {
            double area = Math.Pow(firstParameter, 2);

            return area;
        }

        public static double GetRectangleArea(double firstParameter, double secondParameter)
        {
            double area = firstParameter * secondParameter;

            return area;
        }

        public static double GetCircleArea(double firstParameter)
        {
            double area = Math.PI * Math.Pow(firstParameter , 2);

            return area;
        }
    }
}
