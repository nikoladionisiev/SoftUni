using System;

namespace _13._Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (count <= n)
                    {
                        Console.Write(count + " ");
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
