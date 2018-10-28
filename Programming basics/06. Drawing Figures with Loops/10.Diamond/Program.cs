using System;

namespace _10.Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = 0;
            if (n % 2 != 0)
            {
                k = 1;
            }
            //Upper part
            for (int i = 0; i < n / 2 + k; i++)
            {
                if (n % 2 == 0)
                {
                    Console.WriteLine(new string('-', (n / 2) - 1 - i) + new string('*', 1) + new string('-', 2 * i) + new string('*', 1) + new string('-', (n / 2) - 1 - i));
                }
                else
                {
                    if (i == 0)
                    {
                        Console.WriteLine(new string('-', (n / 2)) + new string('*', 1) + new string('-', (n / 2)));
                    }
                    else
                    {
                        Console.WriteLine(new string('-', (n / 2) - i) + new string('*', 1) + new string('-', 2 * i - 1) + new string('*', 1) + new string('-', (n / 2) - i));
                    }

                }


            }
            //Lower part
            for (int i = 0; i < n / 2 - 1 + k; i++)
            {

                if (n % 2 == 0)
                {
                    Console.WriteLine(new string('-', 1 + i) + new string('*', 1) + new string('-', n - 4 - 2 * i) + new string('*', 1) + new string('-', 1 + i));
                }
                else
                {
                    if (i == n / 2 - 1)
                    {
                        Console.WriteLine(new string('-', (n - 1) / 2) + new string('*', 1) + new string('-', (n - 1) / 2));
                    }
                    else
                    {
                        Console.WriteLine(new string('-', 1 + i) + new string('*', 1) + new string('-', n - 4 - 2 * i) + new string('*', 1) + new string('-', 1 + i));
                    }

                }

            }
        }
    }
}
