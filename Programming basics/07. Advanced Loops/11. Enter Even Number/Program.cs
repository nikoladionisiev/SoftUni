﻿using System;

namespace _11._Enter_Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            while (true)
            {
                try
                {
                    n = int.Parse(Console.ReadLine());

                    try
                    {
                        if (n % 2 == 0)
                        {
                            break;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("The number is not even.");
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid number!");
                }
            }
            Console.WriteLine("Even number entered: {0}", n);
        }
    }
}
