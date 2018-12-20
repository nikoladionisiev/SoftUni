using System;
using System.Linq;

namespace _05._Compare_Char_Arrays
{
    class Program
    {
        static void Main()
        {
            char[] firstArr = Console.ReadLine().Split().Select(char.Parse).ToArray();
            char[] secondArr = Console.ReadLine().Split().Select(char.Parse).ToArray();






            if (firstArr[0] == secondArr[0])
            {
                if (firstArr.Length < secondArr.Length)
                {

                    for (int i = 0; i < firstArr.Length; i++)
                    {
                        Console.Write(firstArr[i]);
                    }
                    Console.WriteLine();
                    for (int i = 0; i < secondArr.Length; i++)
                    {
                        Console.Write(secondArr[i]);
                    }

                }

                else
                {
                    for (int i = 0; i < secondArr.Length; i++)
                    {
                        Console.Write(secondArr[i]);
                    }
                    Console.WriteLine();
                    for (int i = 0; i < firstArr.Length; i++)
                    {
                        Console.Write(firstArr[i]);
                    }

                }
            }

            else
            {

                if (firstArr[0] < secondArr[0])
                {
                    for (int i = 0; i < firstArr.Length; i++)
                    {
                        Console.Write(firstArr[i]);
                    }
                    Console.WriteLine();
                    for (int i = 0; i < secondArr.Length; i++)
                    {
                        Console.Write(secondArr[i]);
                    }
                }

                else if (firstArr[0] > secondArr[0])
                {
                    for (int i = 0; i < secondArr.Length; i++)
                    {
                        Console.Write(secondArr[i]);
                    }
                    Console.WriteLine();
                    for (int i = 0; i < firstArr.Length; i++)
                    {
                        Console.Write(firstArr[i]);
                    }     
                }
            }

            Console.WriteLine();

        }

    }
}
