using System;

namespace _10._Animal_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            var animal = Console.ReadLine().ToLower();
            switch (animal)
            {
                case "dog":
                    Console.WriteLine("mammal");
                    break;
                case "snake":
                    Console.WriteLine("reptile");
                    break;
                case "crocodile":
                    Console.WriteLine("reptile");
                    break;
                case "tortoise":
                    Console.WriteLine("reptile");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
