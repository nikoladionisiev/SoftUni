using System;
using System.Linq;

namespace _5.RubiksMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimension = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rows = dimension[0];
            int cols = dimension[1];

            int[][] rubikmatrix = new int[rows][];

            GetMatrix(rubikmatrix, cols);

          

            int commandsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandsCount; i++)
            {
                string[] input = Console.ReadLine().Split();

                int rowColIndex = int.Parse(input[0]);
                string direction = input[1];
                int moves = int.Parse(input[2]);


                if (direction == "down")
                {
                    MoveDown(rubikmatrix, rowColIndex, moves % rubikmatrix.Length);
                }
                else if (direction == "left")
                {
                    MoveLeft(rubikmatrix, rowColIndex, moves % rubikmatrix[0].Length);
                }
                else if (direction == "right")
                {
                    MoveRight(rubikmatrix, rowColIndex, moves % rubikmatrix[0].Length);
                }
                else if (direction == "up")
                {
                    MoveUp(rubikmatrix, rowColIndex, moves % rubikmatrix.Length);
                }

            }

            int counter = 1;

            for (int row = 0; row < rubikmatrix.Length; row++)
            {
                for (int col = 0; col < rubikmatrix[row].Length; col++)
                {
                    if (rubikmatrix[row][col] == counter )
                    {
                        Console.WriteLine("No swap required");
                        counter++;
                    }
                    else
                    {
                        Rearrange(rubikmatrix, row, col, counter);
                        counter++;
                    }
                }
            }
        }

        private static void Rearrange(int[][] rubikmatrix, int row, int col, int counter)
        {
            for (int targetRow = 0; targetRow < rubikmatrix.Length; targetRow++)
            {
                for (int targetCol = 0; targetCol < rubikmatrix[targetRow].Length; targetCol++)
                {
                    if (rubikmatrix[targetRow][targetCol] == counter)
                    {
                        rubikmatrix[targetRow][targetCol] = rubikmatrix[row][col];
                        rubikmatrix[row][col] = counter;

                        Console.WriteLine($"Swap ({row}, {col}) with ({targetRow}, {targetCol})");
                        return;
                    }
                }
            }
        }

        private static void MoveUp(int[][] rubikmatrix, int col, int moves)
        {
            for (int i = 0; i < moves; i++)
            {
                int firstNumber = rubikmatrix[0][col];

                for (int row = 0; row < rubikmatrix.Length - 1; row++)
                {
                    rubikmatrix[row][col] = rubikmatrix[row + 1][col];
                }
                rubikmatrix[rubikmatrix.Length - 1][col] = firstNumber;
            }
        }

        private static void MoveRight(int[][] rubikmatrix, int row, int moves)
        {
            for (int i = 0; i < moves; i++)
            {
                int lastElement = rubikmatrix[row][rubikmatrix[row].Length - 1];

                for (int col = rubikmatrix.Length - 1; col > 0; col--)
                {
                    rubikmatrix[row][col] = rubikmatrix[row][col - 1];
                }

                rubikmatrix[row][0] = lastElement;
            }
        }

        private static void MoveLeft(int[][] rubikmatrix, int row, int moves)
        {
            for (int i = 0; i < moves; i++)
            {
                int firstElement = rubikmatrix[row][0];

                for (int col = 0; col < rubikmatrix[row].Length - 1; col++)
                {
                    rubikmatrix[row][col] = rubikmatrix[row][col + 1];
                }

                rubikmatrix[row][rubikmatrix[row].Length - 1] = firstElement;
            }
        }

        private static void MoveDown(int[][] rubikmatrix, int col, int moves)
        {
            for (int i = 0; i < moves; i++)
            {
                int lasteElement = rubikmatrix[rubikmatrix.Length - 1][col];

                for (int row = rubikmatrix.Length - 1; row > 0; row--)
                {
                    rubikmatrix[row][col] = rubikmatrix[row - 1][col];
                }

                rubikmatrix[0][col] = lasteElement;
            }
        }

        //private static void Print(int[][] rubikmatrix)
        //{
        //    for (int i = 0; i < rubikmatrix.Length; i++)
        //    {
        //        Console.WriteLine(String.Join(" ", rubikmatrix[i]));
        //    }
        //}

        private static void GetMatrix(int[][] rubikmatrix, int cols)
        {
            int counter = 1;

            for (int row = 0; row < rubikmatrix.Length; row++)
            {
                rubikmatrix[row] = new int[cols];

                for (int col = 0; col < rubikmatrix[row].Length; col++)
                {
                    rubikmatrix[row][col] = counter++;
                   
                }
            }
        }
    }
}
