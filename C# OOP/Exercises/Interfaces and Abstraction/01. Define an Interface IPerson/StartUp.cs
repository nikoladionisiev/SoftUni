using System;

namespace _01._Define_an_Interface_IPerson
{
    class StartUp
    {
        static void Main()
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            IPerson person = new Citizen(name, age);

            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
        }
    }
}
