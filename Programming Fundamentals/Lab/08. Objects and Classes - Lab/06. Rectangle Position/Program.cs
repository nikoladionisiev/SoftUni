using System;

namespace _06._Rectangle_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = ReadRectangle();
            var second = ReadRectangle();

            var result = first.IsInside(second);

            Console.WriteLine(result ? "Inside" : "Not inside");

        }

        static Rectangle ReadRectangle()
        {
            var rectData = Console.ReadLine().Split(' ');

            return new Rectangle
            {
                Left = int.Parse(rectData[0]),
                Top = int.Parse(rectData[1]),
                Width = int.Parse(rectData[2]),
                Height = int.Parse(rectData[3])

            }; 
        }
    }
}
