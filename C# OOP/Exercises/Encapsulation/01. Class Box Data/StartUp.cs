using System;

namespace _01._Class_Box_Data
{
    class StartUp
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            try
            {
                Box box = new Box(length, width, height);

                Console.WriteLine($"Surface area - {box.SurfaceArea():F2}");
                Console.WriteLine($"Lateral surface - {box.LateralSurfaceArea():F2}");
                Console.WriteLine($"Volume - {box.Volume():F2}");
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }

           
        }
    }
}
