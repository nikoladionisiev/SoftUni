using System;

namespace _09._Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var sum = 0;

            for (int index = 0; index < text.Length; index++)
            {
                var currentChar = text[index];
                if (currentChar == 'a')
                {
                    sum += 1;
                }
                else if (currentChar == 'e')
                {
                    sum += 2;
                }
                else if (currentChar == 'i')
                {
                    sum += 3;
                }
                else if (currentChar == 'o')
                {
                    sum += 4;
                }
                else if (currentChar == 'u')
                {
                    sum += 5;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
