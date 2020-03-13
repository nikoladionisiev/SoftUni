using System;
using System.Linq;

namespace _1._Matrix_of_Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rows = input[0];
            int cols = input[1];

            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            string[][] matrix = new string[rows][];

            
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = new string[cols];

                for (int j = 0; j < matrix[i].Length; j++)
                {
                    char firstLetter = alphabet[i];
                    char middleLetter = alphabet[i + j];

                    matrix[i][j] = $"{firstLetter}{middleLetter}{firstLetter} ";

                    Console.Write($"{matrix[i][j]}");
                }
                Console.WriteLine();
            }
        }
    }
}
