using System;

namespace _09._Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var sum = 0;


            while (n > 0)
            {
                int digit = n % 10; //2,2
                sum += digit; //2,4
                n /= 10; //22,2
            }
            Console.WriteLine(sum);
        }
    }
}
