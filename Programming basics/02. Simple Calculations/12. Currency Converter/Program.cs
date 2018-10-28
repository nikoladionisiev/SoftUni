using System;

namespace _12._Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            var value = double.Parse(Console.ReadLine());               

            var inputCurrency = Console.ReadLine();                     
            var outputCurrency = Console.ReadLine();                    

            if (inputCurrency == "USD" && outputCurrency == "BGN")      
            {
                var dollarsToBGN = (value * 1.79549) / 1.0;             

                Console.WriteLine(Math.Round(dollarsToBGN, 2));         
            }

            if (inputCurrency == "USD" && outputCurrency == "EUR")
            {
                var dollarsToEUR = (value * 1.79549) / 1.95583;

                Console.WriteLine(Math.Round(dollarsToEUR, 2));
            }

            if (inputCurrency == "USD" && outputCurrency == "GBP")
            {
                var dollarsToGBP = (value * 1.79549) / 2.53405;

                Console.WriteLine(Math.Round(dollarsToGBP, 2));
            }

            if (inputCurrency == "BGN" && outputCurrency == "USD")
            {
                var levaToUSD = (value * 1.0) / 1.79549;

                Console.WriteLine(Math.Round(levaToUSD, 2));
            }

            if (inputCurrency == "BGN" && outputCurrency == "EUR")
            {
                var levaToEUR = (value * 1.0) / 1.95583;

                Console.WriteLine(Math.Round(levaToEUR, 2));
            }

            if (inputCurrency == "BGN" && outputCurrency == "GBP")
            {
                var levaToGBP = (value * 1.0) / 2.53405;

                Console.WriteLine(Math.Round(levaToGBP, 2));
            }

            if (inputCurrency == "EUR" && outputCurrency == "BGN")
            {
                var euroToBGN = (value * 1.95583) / 1.0;

                Console.WriteLine(Math.Round(euroToBGN, 2));
            }

            if (inputCurrency == "EUR" && outputCurrency == "USD")
            {
                var euroToDollars = (value * 1.95583) / 1.79549;

                Console.WriteLine(Math.Round(euroToDollars, 2));
            }

            if (inputCurrency == "EUR" && outputCurrency == "GBP")
            {
                var euroToGBP = (value * 1.95583) / 2.53405;

                Console.WriteLine(Math.Round(euroToGBP, 2));
            }

            if (inputCurrency == "GBP" && outputCurrency == "BGN")
            {
                var GBPtoBGN = (value * 2.53405) / 1.0;

                Console.WriteLine(Math.Round(GBPtoBGN, 2));
            }

            if (inputCurrency == "GBP" && outputCurrency == "USD")
            {
                var GBPtoUSD = (value * 2.53405) / 1.79549;

                Console.WriteLine(Math.Round(GBPtoUSD, 2));
            }

            if (inputCurrency == "GBP" && outputCurrency == "EUR")
            {
                var GBPtoEUR = (value * 2.53405) / 1.95583;

                Console.WriteLine(Math.Round(GBPtoEUR, 2));
            }
        }
    }
}
