using System;

namespace _03._Players_and_Monsters
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var hero1 = new SoulMaster("Nick", 25);
            var hero2 = new MuseElf("Polly", 24);

            Console.WriteLine(hero1);
            Console.WriteLine(hero2);
        }
    }
}
