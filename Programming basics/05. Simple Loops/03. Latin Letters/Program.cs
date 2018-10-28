using System;

namespace _03._Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Latin alphabet:");

            for (char letter = 'a'; letter <= 'z'; letter++)
            {
                Console.WriteLine(" " + letter);
            }
        }
    }
}
