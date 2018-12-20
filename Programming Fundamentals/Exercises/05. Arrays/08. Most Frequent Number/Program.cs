using System;
using System.Linq;

namespace _08._Most_Frequent_Number
{
    class Program
    {
        static void Main()
        {

            long[] numbers = Console.ReadLine().Split().Select(long.Parse).ToArray();

            
            long count = 0;
            long frequentNumber = 0;
            long bestCount = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        count++;
                        
                        if (count > bestCount)
                        {
                            bestCount = count;
                            frequentNumber = numbers[i];

                        }
                        
                    }

                }
                    count = 0;
            }
            Console.WriteLine(frequentNumber);
          
        }
    }
}
