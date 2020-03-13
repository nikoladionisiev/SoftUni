using System;
using System.Linq;

namespace _2.DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] input = Console.ReadLine().Split( new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = input[j];
                }
            }

            int sumFirstDiagonal = 0;
            int sumSecondDiagonal = 0;

            int backCounter = matrix.GetLength(1) - 1;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sumFirstDiagonal += matrix[i, i];
                sumSecondDiagonal += matrix[i, backCounter];
                backCounter--;

            }

            


            int result = Math.Abs(sumFirstDiagonal - sumSecondDiagonal);

            Console.WriteLine(result);

          
           
        }
    }
}
