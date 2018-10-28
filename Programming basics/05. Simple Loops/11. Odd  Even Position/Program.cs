using System;

namespace _11._Odd__Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double oddSum = 0.0;
            double evenSum = 0.0;
            double oddMax = double.MinValue;
            double evenMax = double.MinValue;
            double oddMin = double.MaxValue;
            double evenMin = double.MaxValue;

            for (int i = 1; i <= n; i++)
            {
                double num = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    if (num > evenMax)
                    {
                        evenMax = num;
                    }
                    if (num < evenMin)
                    {
                        evenMin = num;
                    }
                    evenSum += num;

                }
                else
                {

                    if (num > oddMax)
                    {
                        oddMax = num;
                    }
                    if (num < oddMin)
                    {
                        oddMin = num;
                    }

                    oddSum += num;
                }
            }
            Console.WriteLine("OddSum={0}", oddSum);


            if (oddMin == double.MaxValue)
            {

                Console.WriteLine("OddMin=No");
            }
            else
            {
                Console.WriteLine("OddMin={0}", oddMin);
            }
            if (oddMax == double.MinValue)
            {

                Console.WriteLine("OddMax=No");
            }
            else
            {
                Console.WriteLine("OddMax={0}", oddMax);
            }
            Console.WriteLine("EvenSum={0}", evenSum);
            if (evenMin == double.MaxValue)
            {

                Console.WriteLine("EvenMin=No");
            }
            else
            {
                Console.WriteLine("EvenMin={0}", evenMin);
            }
            if (evenMax == double.MinValue)
            {

                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine("EvenMax={0}", evenMax);
            }

        }
    }
}
