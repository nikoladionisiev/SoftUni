using System;
using System.Linq;

namespace _4.MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int[,] matrix = new int[size[0], size[1]];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = input[j];
                }
            }

            int sum = 0;
            int result = 0;
            int rawIndex = 0;
            int colIndex = 0;

            for (int i = 0; i < matrix.GetLength(0) -2; i++)
            {

                for (int j = 0; j < matrix.GetLength(1) - 2; j++)
                {
                    sum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2] +
                           matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2] +
                           matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];
                    if (sum > result)
                    {
                        result = sum;
                        rawIndex = i;
                        colIndex = j;
                    }

                }
            }

            Console.WriteLine($"Sum = {result}");

            for (int i = rawIndex; i <= rawIndex + 2; i++)
            {
                for (int j = colIndex; j <= colIndex + 2; j++)
                {
                    Console.Write($"{matrix[i,j]} ");
                }
                Console.WriteLine();
            }
           
        }
    }
}
