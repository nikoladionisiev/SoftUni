using System;

namespace _02.Creating_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Person firstPerson = new Person("Pesho", 25);
            Person secondPerson = new Person("Acho", 28);
            Person thirdPerson = new Person("Gosho", 24);

            Console.WriteLine(firstPerson);
            Console.WriteLine(secondPerson);
            Console.WriteLine(thirdPerson);
        }
    }
}
