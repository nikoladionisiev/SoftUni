using System;
using System.Collections.Generic;

namespace _06._Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> parkingLot = new HashSet<string>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(", ");

                string command = input[0];

                if (command == "IN")
                {
                    parkingLot.Add(input[1]);
                }
                else if (command == "OUT")
                {
                    parkingLot.Remove(input[1]);
                }
                else if (command == "END")
                {
                    if (parkingLot.Count <= 0)
                    {
                        Console.WriteLine("Parking Lot is Empty");
                    }
                    else
                    {
                        foreach (var car in parkingLot)
                        {                      
                                Console.WriteLine(car);                       
                        }
                    }
                    break;
                }
            }
        }
    }
}
