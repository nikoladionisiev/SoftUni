using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            int middlePartIndex = input.Count / 2;
            int firstThirdIndex = input.Count / 4;

            List<int> firstPart = new List<int>();
            List<int> middlePart = new List<int>();
            List<int> thirdPart = new List<int>();

            for (int  i = 0;  i < input.Count;  i++)
            {
                if (i < firstThirdIndex)
                {
                    firstPart.Add(input[i]);
                }
                else if(i >= firstThirdIndex && i < firstThirdIndex + middlePartIndex)
                {
                    middlePart.Add(input[i]);
                }
                else
                {
                    thirdPart.Add(input[i]);
                }
            }

            firstPart.Reverse();
            thirdPart.Reverse();

            for (int k = 0; k < middlePart.Count; k++)
            {
                if (k < firstPart.Count)
                {
                    Console.Write((firstPart[k] + middlePart[k]) + " ");
                }
                else
                {
                    Console.Write((thirdPart[k - firstPart.Count] + middlePart[k]) + " ");
                }
            }



        
        }
    }
}
