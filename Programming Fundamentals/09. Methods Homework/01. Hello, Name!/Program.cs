using System;

namespace _01._Hello__Name_
{
    class Program
    {
        static void Main()
        {
            string name = Console.ReadLine();

            PrintName(name);
        }

        public static void PrintName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
