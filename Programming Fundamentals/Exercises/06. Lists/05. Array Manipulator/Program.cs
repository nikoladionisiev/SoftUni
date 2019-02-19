using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {

                string line = Console.ReadLine();

                string[] elements = line.Split();

                //add
                if (elements[0] == "add")
                {
                    numbers.Insert(int.Parse(elements[1]), int.Parse(elements[2]));
                }

                //add many
                else if (elements[0] == "addMany")
                {
                    int index = int.Parse(elements[1]);
                    for (int i = 2; i < elements.Length; i++)
                    {

                        numbers.Insert(index, int.Parse(elements[i]));
                        index += 1;
                    }
                }

                //contains
                else if (elements[0] == "contains")
                {

                    Console.WriteLine(numbers.IndexOf(int.Parse(elements[1])));



                    //for (int j = 0; j < numbers.Count; j++)
                    //{


                    //    if (numbers.Contains(int.Parse(elements[1])))
                    //    {
                    //        Console.WriteLine(numbers.IndexOf(int.Parse(elements[1])));
                    //        break;
                    //    }
                    //    else
                    //    {
                    //        Console.WriteLine(-1);
                    //        break;
                    //    }


                    //}
                }

                //remove
                else if (elements[0] == "remove")
                {
                    numbers.RemoveAt(int.Parse(elements[1]));

                }

                //shift positions
                else if (elements[0] == "shift")
                {
                    for (int i = 0; i < int.Parse(elements[1]); i++)
                    {
                        int first = numbers[0];

                        for (int j = 1; j < numbers.Count; j++)
                        {
                            numbers[j - 1] = numbers[j];
                        }
                        numbers[numbers.Count - 1] = first;
                    }

                }

                //sum of pairs
                else if (elements[0] == "sumPairs")
                {
                    List<int> pairs = new List<int>();

                    for (int i = 0; i < numbers.Count; i += 2)
                    {
                        try
                        {
                            pairs.Add(numbers[i] + numbers[i + 1]);

                        }
                        catch (Exception)
                        {
                            pairs.Add(numbers[i]);
                        }
                    }

                    numbers = pairs;

                }

                else if (elements[0] == "print")
                {

                    Console.WriteLine("[" + string.Join(", ", numbers) + "]");
                    break;
                }



            }


        }
    }
}
