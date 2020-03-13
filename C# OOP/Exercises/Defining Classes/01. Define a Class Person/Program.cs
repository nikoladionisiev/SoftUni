using System;

namespace _01._Define_a_Class_Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Person firstPerson = new Person();

            firstPerson.Name = "Pesho";
            firstPerson.Age = 20;

            Person secondPerson = new Person();
            secondPerson.Name = "Gosho";
            secondPerson.Age = 18;

            Person thirdPerson = new Person();
            thirdPerson.Name = "Stamat";
            thirdPerson.Age = 43;


            Console.WriteLine(firstPerson);
            Console.WriteLine(secondPerson);
            Console.WriteLine(thirdPerson);
        }
    }
}
