using System;
using System.Globalization;

namespace _13._1000_Days_After_Birth
{
    class Program
    {
        static void Main(string[] args)
        {
            var birthDateAsString = Console.ReadLine();

            var format = "dd-MM-yyyy";
            var birthDate = DateTime.ParseExact(birthDateAsString, format, CultureInfo.InvariantCulture);
            birthDate = birthDate.AddDays(999);

            Console.WriteLine(birthDate.ToString(format));
        }
    }
}
