using System;
using System.Linq;

namespace _04._Opinion_Poll
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Family family = new Family();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                string name = input[0];
                int age = int.Parse(input[1]);

                Person person = new Person(name, age);

                family.Members.Add(person);
            }

            foreach (var item in family.Members.OrderBy(x => x.Name).Where(x => x.Age > 30))
            {
                Console.WriteLine($"{item.Name} -> {item.Age}");
            }
        }
    }
}
