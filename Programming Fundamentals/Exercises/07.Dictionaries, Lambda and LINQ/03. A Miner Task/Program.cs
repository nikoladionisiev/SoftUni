using System;
using System.Collections.Generic;

namespace _03._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> quantities = new Dictionary<string, int>();

            string input = "";
            string resource = "";
            int index = 0;

            while (true)
            {
                resource = input;
                input = Console.ReadLine();

                if (input == "stop")
                {
                    break;
                }


                if (index % 2 == 0)
                {
                    if (!quantities.ContainsKey(input))
                    {
                        quantities[input] = 0;

                    }
                }
                else
                {
                    quantities[resource] += int.Parse(input);
                }
                index++;


            }

            foreach (var entry in quantities)
            {
                Console.WriteLine(entry.Key + " -> " + entry.Value);
            }
        }
    }
}
