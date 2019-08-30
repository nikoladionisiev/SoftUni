using System;
using System.Text;

namespace _03._Unicode_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            foreach (var letter in input)
            {
                string result = ((int)letter).ToString("x4");
                Console.Write("\\u" + result);
            }
        }
    }
}
