using System;

namespace _4.SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];
            for (int i = 0; i < size; i++)
            {
                char[] array = Console.ReadLine()
                    .ToCharArray();
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = array[j];
                }
            }

            PrintMatrix(matrix);
           
        }

        private static void PrintMatrix(char[,] matrix)
        {

            string symbol = Console.ReadLine();
            bool isSymbol = false;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j].ToString() == symbol)
                    {
                        Console.WriteLine($"({i}, {j})");
                        isSymbol = true;
                        return;
                    }
                }

            }

            if (isSymbol == false)
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
        }
    }
}
