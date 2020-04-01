using System;

namespace _02._Multiple_Inheritance
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Puppy puppy = new Puppy();

            puppy.Eat();
            puppy.Bark();
            puppy.Weep();
        }
    }
}
