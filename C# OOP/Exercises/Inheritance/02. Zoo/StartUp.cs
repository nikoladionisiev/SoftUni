using System;

namespace _02._Zoo
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            Animal animal = new Animal(name);
        }
    }
}
