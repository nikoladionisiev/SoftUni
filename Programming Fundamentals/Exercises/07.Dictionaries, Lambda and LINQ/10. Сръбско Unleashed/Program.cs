using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._Сръбско_Unleashed
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> data = new Dictionary<string, Dictionary<string, long>>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "End") break;
                string[] info = line.Split(' ');

                //Console.WriteLine(ValidateLine(info));
                if (ValidateLine(info))
                {
                    bool nameBool = true;
                    bool venueBool = false;
                    bool numBool = false;
                    string name = "";
                    string venue = "";
                    long num = 0;

                    for (int i = 0; i < info.Length - 1; i++)
                    {
                        if (info[i].StartsWith("@"))
                        {
                            nameBool = false;
                            venueBool = true;
                        }
                        else if (int.TryParse(info[i], out int n))
                        {
                            venueBool = false;
                            numBool = true;
                        }

                        if (nameBool)
                        {
                            name += info[i] + " ";
                        }
                        else if (venueBool)
                        {
                            venue += info[i] + " ";
                        }
                        else if (numBool)
                        {
                            num = long.Parse(info[i]) * long.Parse(info[i + 1]);
                        }
                    }
                    if (data.ContainsKey(venue))
                    {
                        if (data[venue].ContainsKey(name))
                        {
                            data[venue][name] += num;
                        }
                        else
                        {
                            data[venue].Add(name, num);
                        }
                    }
                    else
                    {
                        data.Add(venue, new Dictionary<string, long>());
                        data[venue].Add(name, num);
                    }

                }
            }

            foreach (var entry in data)
            {
                foreach (char i in entry.Key)
                {
                    if (i != '@')
                    {
                        Console.Write(i);
                    }
                }
                Console.WriteLine();
                foreach (var item in entry.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {item.Key}-> {item.Value}");
                }
            }
        }

        static bool ValidateLine(string[] arr)
        {
            if (arr.Length < 4) return false;
            bool validVenue = false;
            bool validNum = false;

            foreach (string i in arr)
            {
                if (i.StartsWith("@"))
                {
                    validVenue = true;
                }
                validNum = int.TryParse(i, out int n);
            }

            return validVenue && validNum;
        }
    }
}
