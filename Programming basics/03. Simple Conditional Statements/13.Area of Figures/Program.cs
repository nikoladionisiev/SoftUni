using System;

namespace _13.Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            var figure = Console.ReadLine();

            if (figure == "square")
            {
                var a = double.Parse(Console.ReadLine());

                var area = a * a;

                Console.WriteLine(area);
            }

            else if (figure == "rectangle")
            {
                var a = double.Parse(Console.ReadLine());
                var b = double.Parse(Console.ReadLine());
                var area = a * b;

                Console.WriteLine(area);
            }

            else if (figure == "circle")
            {
                var r = double.Parse(Console.ReadLine());

                var area = Math.PI * r * r;

                Console.WriteLine(Math.Round(area, 3));
            }

            if (figure == "triangle")
            {
                var c = double.Parse(Console.ReadLine());
                var hc = double.Parse(Console.ReadLine());

                var area = (c * hc) / 2;

                Console.WriteLine(area);
            }
        }
    }
}
