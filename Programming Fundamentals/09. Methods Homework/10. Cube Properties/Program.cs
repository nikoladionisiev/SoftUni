using System;

namespace _10._Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();

            double result = 0.0;

            if (parameter == "face")
            {
               result = GetFaceDiagonal(side);
            }
            else if (parameter == "space")
            {
               result = GetSpaceDiagonal(side);
            }
            else if (parameter == "volume")
            {
               result = GetVolume(side);
            }
            else if (parameter == "area")
            {
               result = GetArea(side);
            }

            Console.WriteLine($"{result , 0:F2}");

        }

        public static double GetFaceDiagonal(double side)
        {
            double result = Math.Sqrt(2 * Math.Pow(side, 2));

            return result;
        }

        public static double GetSpaceDiagonal(double side)
        {
            double result = Math.Sqrt(3 * Math.Pow(side, 2));

            return result;
        }

        public static double GetVolume(double side)
        {
            double result = Math.Pow(side, 3);

            return result;
        }

        public static double GetArea(double side)
        {
            double result = 6 * Math.Pow(side, 2);

            return result;
        }
    }
}
