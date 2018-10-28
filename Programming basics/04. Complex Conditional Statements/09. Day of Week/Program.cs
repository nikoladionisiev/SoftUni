using System;

namespace _09._Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine().ToLower());

            switch (num)
            {
                case 1:
                    Console.WriteLine("monday");
                    break;
                case 2:
                    Console.WriteLine("tuesday");
                    break;
                case 3:
                    Console.WriteLine("wednesday");
                    break;
                case 4:
                    Console.WriteLine("thursday");
                    break;

                case 5:
                    Console.WriteLine("friday");
                    break;
                case 6:
                    Console.WriteLine("saturday");
                    break;
                case 7:
                    Console.WriteLine("sunday");
                    break;

                case -1:
                    Console.WriteLine("error");
                    break;
                default:
                    Console.WriteLine("error");
                    break;


            }
        }
    }
}
