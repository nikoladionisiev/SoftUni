using System;

namespace _03._Oldest_Family_Member
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleNumber = int.Parse(Console.ReadLine());

            Family family = new Family();

            for (int i = 0; i < peopleNumber; i++)
            {
                string[] input = Console.ReadLine().Split();

                string name = input[0];
                int age = int.Parse(input[1]);

                Person person = new Person(name, age);
                family.AddMember(person);
            }

            Person oldestPerson = family.GetOldestMember();

            Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");
        }
    }
}
