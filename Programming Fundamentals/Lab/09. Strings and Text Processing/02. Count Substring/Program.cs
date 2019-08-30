using System;

namespace _02._Count_Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string quote = Console.ReadLine().ToLower();
            string keyword = Console.ReadLine().ToLower();

            int counter = 0;
            int index = quote.IndexOf(keyword);

            while (index != -1)
            {
                index = quote.IndexOf(keyword, index + 1);
                counter++;
            }

            Console.WriteLine(counter);
        }
    }
}
