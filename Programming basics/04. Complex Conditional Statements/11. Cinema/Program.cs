using System;

namespace _11._Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string vhod = Console.ReadLine().ToLower();
            var row = int.Parse(Console.ReadLine());
            var column = int.Parse(Console.ReadLine());

            double result = -1.00;

            if (vhod == "premiere")
            {
                result = row * column * 12.00;
            }
            else if (vhod == "normal")
            {
                result = row * column * 7.50;
            }
            else if (vhod == "discount")
            {
                result = row * column * 5.00;
            }
            Console.WriteLine("{0:f2} leva", result);
        }
    }
}
